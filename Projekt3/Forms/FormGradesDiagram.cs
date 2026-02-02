using System.Data;
using System.Windows.Forms.DataVisualization.Charting;

namespace Projekt3.Forms
{
    public partial class FormGradesDiagram : Form
    {
        public StudentsGroup Group { get; private set; }

        public FormGradesDiagram(StudentsGroup group)
        {
            InitializeComponent();

            Group = group;
        }

        private void FormGradesDiagram_Load(object sender, EventArgs e)
        {
            ShowSubjectCharts(Group);
        }

        private void ShowSubjectCharts(StudentsGroup group)
        {
            tabControl1.TabPages.Clear();

            foreach (var subject in group.AssignedSubjects)
            {
                TabPage tp = new TabPage(subject.Name);

                Chart subjectChart = CreateStyledGradeChart(group, subject.Name);
                subjectChart.Dock = DockStyle.Fill;

                tp.Controls.Add(subjectChart);
                tabControl1.TabPages.Add(tp);
            }
        }

        private Chart CreateStyledGradeChart(StudentsGroup group, string subjectName)
        {
            Chart chart = new Chart();
            ChartArea area = new ChartArea("MainArea");

            area.AxisX.Title = "Ocena";
            area.AxisY.Title = "Liczba studentów";
            area.AxisY.Interval = 1;
            area.AxisY.MajorGrid.LineColor = Color.LightGray;
            area.AxisX.MajorGrid.Enabled = false;
            chart.ChartAreas.Add(area);

            var gradesData = group.Students
                .SelectMany(s => s.Grades)
                .Where(g => g.Subject.Name == subjectName)
                .GroupBy(g => g.Value)
                .Select(res => new { Grade = res.Key, Count = res.Count() })
                .OrderBy(x => x.Grade)
                .ToList();

            Series series = new Series("GradesDistribution");
            series.ChartType = SeriesChartType.Column;
            series.BorderColor = Color.Black;
            series.BorderWidth = 1;
            series["PointWidth"] = "0.8";

            foreach (var item in gradesData)
            {
                int pointIndex = series.Points.AddXY(item.Grade, item.Count);

                if (Math.Abs(item.Grade - 2.0f) < 0.01)
                {
                    series.Points[pointIndex].Color = Color.Red;
                }
                else
                {
                    series.Points[pointIndex].Color = Color.Green;
                }
            }

            chart.Series.Add(series);
            chart.Titles.Add(new Title($"Rozkład ocen dla: {subjectName}\nGrupa: {group.GroupName}",
                            Docking.Top, new Font("Arial", 12, FontStyle.Bold), Color.Black));

            return chart;
        }
    }
}

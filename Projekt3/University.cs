using System.Text.Json;

namespace Projekt3
{
    public class University
    {
        public List<FieldOfStudy> Fields { get; set; } = new List<FieldOfStudy>();

        public void AddStudyField(FieldOfStudy field)
        {
            Fields.Add(field);
        }

        public void UpdateJson()
        {
            var options = new JsonSerializerOptions { WriteIndented = true };

            try
            {
                string documents = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string path = Path.Combine(documents, "Dziennik.json");

                string jsonString = JsonSerializer.Serialize(Fields, options);
                File.WriteAllText(path, jsonString);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void DeleteStudyField(string fieldName)
        {
            //TODO: dodaj logikę usuwania kierunków
        }

        //TODO: dodaj to do jakiejs innej klasy, zeby dalo sie tego do roznych rzeczy uzywac
        public void LoadFieldsOfStudy(string path)
        {
            if (!File.Exists(path)) return;

            try
            {
                string jsonString = File.ReadAllText(path);
                var loadedFields = JsonSerializer.Deserialize<List<FieldOfStudy>>(jsonString);

                if (loadedFields != null)
                {
                    Fields = loadedFields;
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}

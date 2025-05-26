using OfficeMate.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace OfficeMate.Storage
{
    public static class ContactStorage
    {
        private static readonly string defaultPath = "OfficeMateContacts.json";

        public static void SaveContacts(List<Contact> contacts, string filePath = null)
        {
            var json = JsonSerializer.Serialize(contacts, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath ?? defaultPath, json);
        }

        public static List<Contact> LoadContacts(string filePath = null)
        {
            var path = filePath ?? defaultPath;
            if (!File.Exists(path))
                return new List<Contact>();

            var json = File.ReadAllText(path);
            return JsonSerializer.Deserialize<List<Contact>>(json) ?? new List<Contact>();
        }
    }
}

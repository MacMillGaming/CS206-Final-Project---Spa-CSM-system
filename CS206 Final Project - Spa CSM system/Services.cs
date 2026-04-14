using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS206_Final_Project___Spa_CSM_system
{
    // Services is the third required custom class for this project.
    // It models a single spa/salon service offering with all its details,
    // and also acts as the master catalog that the rest of the application reads from.
    public class Services
    {
        // ── Properties ────────────────────────────────────────────────────────
        // Each property stores one piece of information about the service.
        // { get; set; } means the value can be both read and changed from outside the class.

        public string Name { get; set; } = "";   // e.g. "Swedish Massage"
        public string Category { get; set; } = "";   // e.g. "Massage", "Facial", "Nails"
        public decimal Price { get; set; }          // e.g. 85.00
        public int DurationMinutes { get; set; }      // e.g. 60

        // ── Constructors ──────────────────────────────────────────────────────
        // The empty constructor lets C# create a Services object with no arguments,
        // which is required when reading records back from the file line-by-line.
        public Services() { }

        // The full constructor lets us create a fully filled-in Services object in one line.
        public Services(string name, string category, decimal price, int durationMinutes)
        {
            Name = name;
            Category = category;
            Price = price;
            DurationMinutes = durationMinutes;
        }

        // ── Methods ───────────────────────────────────────────────────────────

        // ToString() is called automatically whenever C# needs a text version of the object,
        // for example when it is added to a ComboBox. Returning the Name means the combo box
        // shows "Swedish Massage" instead of the class type name.
        public override string ToString() => Name;

        // GetDisplayText() gives a richer description used in ListBoxes and reports.
        public string GetDisplayText() =>
            $"{Name} | {Category} | ${Price:F2} | {DurationMinutes} min";

        // ── Static catalog ────────────────────────────────────────────────────
        // GetAllServices() is a static method, meaning you call it on the class itself
        // (Services.GetAllServices()) rather than on a specific instance.
        // It returns the complete menu of services offered by the spa/salon.
        // Using a static method here means every form gets exactly the same list
        // without any form having to create a Services object first.
        public static List<Services> GetAllServices()
        {
            return new List<Services>
            {
                // Massage category
                new Services("Swedish Massage",    "Massage",  85.00m,  60),
                new Services("Deep Tissue Massage","Massage", 100.00m,  60),
                new Services("Hot Stone Massage",  "Massage", 120.00m,  90),

                // Facial category
                new Services("Classic Facial",     "Facial",   70.00m,  45),
                new Services("Hydrating Facial",   "Facial",   90.00m,  60),

                // Nails category
                new Services("Manicure",           "Nails",    35.00m,  30),
                new Services("Pedicure",           "Nails",    45.00m,  45),
                new Services("Gel Manicure",       "Nails",    50.00m,  45),

                // Hair category
                new Services("Haircut",            "Hair",     40.00m,  30),
                new Services("Blowout & Style",    "Hair",     55.00m,  45),
                new Services("Hair Coloring",      "Hair",    120.00m, 120),

                // Body & Waxing category
                new Services("Body Scrub",         "Body",     80.00m,  60),
                new Services("Waxing - Eyebrow",   "Waxing",   20.00m,  15),
                new Services("Waxing - Full Leg",  "Waxing",   60.00m,  45),
            };
        }

        // GetCategories() returns only the unique category names.
        // This is used to populate the service-filter ComboBox in ApptSummaryForm.
        public static List<string> GetCategories()
        {
            // Use a HashSet to automatically eliminate duplicates, then sort alphabetically.
            HashSet<string> seen = new HashSet<string>();
            List<string> categories = new List<string>();

            foreach (Services s in GetAllServices())
            {
                if (seen.Add(s.Category))   // Add() returns false if already present
                    categories.Add(s.Category);
            }

            categories.Sort();
            return categories;
        }

        // GetServiceNames() returns just the Name strings.
        // Used to quickly fill a ComboBox with only names when full objects aren't needed.
        public static List<string> GetServiceNames()
        {
            List<string> names = new List<string>();
            foreach (Services s in GetAllServices())
                names.Add(s.Name);
            return names;
        }
    }
}

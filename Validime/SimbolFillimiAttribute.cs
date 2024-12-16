using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Universiteti2024.Validime
{
    public class SimbolFillimiAttribute : ValidationAttribute
    {
        private readonly string _prefix;

        public SimbolFillimiAttribute(string prefix)
        {
            _prefix = prefix;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string kursi = value.ToString();

            // Kontrollon nese emri fillon me prefiksin e caktuar
            if (!kursi.StartsWith(_prefix))
            {
                return new ValidationResult($"Emri i kursit duhet te filloje me '{_prefix}'.");
            }

            return ValidationResult.Success;
        }
    }
}
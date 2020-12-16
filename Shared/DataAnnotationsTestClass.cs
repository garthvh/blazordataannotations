using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BlazorDataAnnotations {
     

    public class DataAnnotationsTestClass
    {


        [Display(Name = "First Name", ShortName = "First", Prompt = "Please enter a first name."), DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText = "[Null]")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "That is not a real first name.")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name", ShortName = "Last", Prompt = "Please enter a last name."), DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText = "[Null]")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "That is not a real last name.")]
        public string LastName { get; set; }

        [DisplayFormat(DataFormatString="{0:C}")]
        [Display(Name = "Money Field", ShortName = "$$ Bill", Prompt="Let the dollar circulate", Description = "A double field that stores money.")]
        [Category("Numbers")]
        [Browsable(true)]
        public double MoneyField { get; set; }

        [DisplayName("Forcast Date")]    
        [Required(ErrorMessage = "Forcast Date is Required")]
        [DisplayFormat(DataFormatString = "{0:M/d/yyyy}")]
        public DateTime ForcastDate { get; set; }

        [DisplayName("Last Updated")]    
        [DisplayFormat(DataFormatString = "{0:dddd, MMMM d, yyyy h:mm tt}")]
        public DateTime LastUpdated { get; set; }

        [Display(Name = "Temperature Celsius", ShortName = "Temp. (C)")]
        [DisplayFormat(DataFormatString="{0}\u00B0C", ConvertEmptyStringToNull = true, NullDisplayText = "N/A")]
        public int TemperatureCelsius { get; set; }

        [Display(Name = "Temperature Fahrenheit", ShortName = "Temp. (F)")]
        [DisplayFormat(DataFormatString="{0}\u00B0F", ConvertEmptyStringToNull = true, NullDisplayText = "N/A")]
        public int TemperatureFahrenheit { get; set; }

        [Display(Name="Summary", ShortName = "Sum.", Prompt = "Enter a Summary", GroupName="Deets", 
        Description = "A random summary of something.")]
        public string Summary { get; set; }
    }
}
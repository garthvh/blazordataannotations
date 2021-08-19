using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BlazorDataAnnotations {
     
    public class DataAnnotationsTestClass
    {

        [Display(Name = "First Name", ShortName = "First", Prompt = "Please enter a first name."), DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText = "[Null]")]
        [RegularExpression(@"^[a-zA-Z'-_ ]*$")]
        [StringLength(30, MinimumLength = 2)]
        [Required(ErrorMessage = "First name is required.")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name", ShortName = "Last", Prompt = "Please enter a last name."), DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText = "[Null]")]
        [StringLength(50, MinimumLength = 2)]
        [RegularExpression(@"^[a-zA-Z'-_ ]*$")]
        [Required(ErrorMessage = "Last name is required.")]
        public string LastName { get; set; }

        [Display(Name = "Email address", ShortName ="Email", Prompt = "your@someemail.com")]
        [Required(ErrorMessage = "Email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Display(Name = "Address", ShortName ="Addr", Prompt = "123 East West Street")]
        [Required]
        [StringLength(80, MinimumLength = 10)]
        public string Address { get; set; }

        [Display(Name = "Address 2", ShortName ="Addr2", Prompt = "Apartment or Unit Number")]
        [StringLength(80, MinimumLength = 10)]
        public string Address2 { get; set; }

        [Display(Name = "City", ShortName ="City", Prompt = "City Name")]
        [StringLength(80, MinimumLength = 3)]
        [Required]
        public string City { get; set; }

        [Display(Name = "State", ShortName ="State", Prompt = "Select a state")]
        [StringLength(2, MinimumLength = 2)]
        [Required]
        public string State { get; set; }

        [Display(Name = "Zip Code", ShortName ="Zip", Prompt = "Enter a zip code")]
        [Required(ErrorMessage = "Zip is Required")]
        [RegularExpression(@"^\d{5}(-\d{4})?$", ErrorMessage = "Invalid Zip")]
        public string Zip { get; set; }

        [Display(Name = "Movie Genre", ShortName = "Genre")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [StringLength(30)]
        public string MovieGenre { get; set; }

        [Display(Name = "Movie Rating", ShortName = "Rating")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(5)]
        public string MovieRating { get; set; }

        [Display(Name = "Release Date", ShortName = "Release")]
        [DataType(DataType.Date)]
        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? ReleaseDate { get; set; }

        [Display(Name = "Routing Number", ShortName = "Routing")]
        [StringLength(9, MinimumLength = 9, ErrorMessage = "Routing number must be 9 digits")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Only numbers are allowed in routing numbers")]
        public string RoutingNumber { get; set; }

        [DisplayName("Expiration Date")]    
        [Required]
        [DisplayFormat(DataFormatString = "{0:M/d/yyyy}")]
        public DateTime ExpirationDate { get; set; }

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
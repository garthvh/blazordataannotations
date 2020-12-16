using System;

namespace BlazorDataAnnotations {
    public class DataAnnotationsDetails
    {
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string ShortName { get; set; }
        public string Prompt { get; set; }
        public string GroupName { get; set; }       
        public string DataFormatString{ get; set; }
        public string NullDisplayText{ get; set; }
        public string Description{ get; set; }
        public string Category{ get; set; }
        public bool Browsable{ get; set; }
        public string PropertyType{ get; set; }
        public string SerializationVisibility{ get; set; }
        public string Attributes{ get; set; }
        public bool Required { get; set; }
        public string ErrorMessage { get; set; }
    }

}
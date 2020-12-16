using System;
using System.Linq;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using BlazorDataAnnotations;

namespace BlazorDataAnnotations.Helpers
{
    public class HelperFunctions
    {
        public List<DataAnnotationsDetails> GetDataAnnotationsDetailsList(string className)
        {
            object currentClassInstance = CreateClassByName(className);

            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(currentClassInstance, true);
            List<DataAnnotationsDetails> listFieldDetails = new List<DataAnnotationsDetails>();
            foreach (PropertyDescriptor property in properties)
            {
                AttributeCollection attributes = property.Attributes;

                RequiredAttribute requiredAttribute = (RequiredAttribute)attributes[typeof(RequiredAttribute)];
                DisplayAttribute displayAttribute = (DisplayAttribute)attributes[typeof(DisplayAttribute)];
                DisplayFormatAttribute displayFormatAttribute = (DisplayFormatAttribute)attributes[typeof(DisplayFormatAttribute)];
                string displayName = "",  shortName = "", prompt = "", description = "", groupName = "", dataFormatString = "", nullDisplayText = "", attributeList = "";
                displayName = property.DisplayName;
            
                if(displayAttribute != null)
                {
                    // DisplayName and Description both have single purpose attributes
                    displayName = displayAttribute.Name ?? displayName;
                    description = displayAttribute.Description ?? description;                   
                    shortName = displayAttribute.ShortName ?? "";
                    prompt = displayAttribute.Prompt ?? "";
                    groupName =  displayAttribute.GroupName ?? ""; 
                }

                if(displayFormatAttribute != null)
                {
                    dataFormatString = displayFormatAttribute.DataFormatString ?? ""; 
                    nullDisplayText = displayFormatAttribute.NullDisplayText ?? "";
                } 
                foreach(Attribute attr in property.Attributes)
                {
                    attributeList += attr.GetType().Name + ",";

                }

                DataAnnotationsDetails dad = new DataAnnotationsDetails
                {
                    Name = property.Name, 
                    DisplayName = displayName,
                    ShortName = shortName,
                    Prompt = prompt,
                    GroupName = groupName,
                    Description = description,
                    Category = property.Category,
                    DataFormatString =  dataFormatString,
                    NullDisplayText =  nullDisplayText,
                    Required = (requiredAttribute != null),
                    Attributes = attributeList.TrimEnd(','),
                    Browsable = property.IsBrowsable,
                    PropertyType = property.PropertyType.Name,
                    SerializationVisibility = property.SerializationVisibility.ToString()
                    
                };
                if(requiredAttribute != null)
                {
                    dad.ErrorMessage = requiredAttribute.ErrorMessage;
                }
                listFieldDetails.Add(dad);
            }
            return listFieldDetails;
        }

        private static object CreateClassByName(string className)
        {
            var currentClass = (from assembly in AppDomain.CurrentDomain.GetAssemblies()
                        from c in assembly.GetTypes()
                        where c.Name == className
                        select c).FirstOrDefault();

            if (currentClass == null)
                throw new InvalidOperationException("Class " + className + " not found");

            return Activator.CreateInstance(currentClass);
        }
    }
}   

namespace PackageManagerTool.Core.Model.TrackingSystem
{
    public class PackagingType
    {
        public  PackagingType(string ReferenceImage, string PackageDescription )
        {
            reference_image = ReferenceImage;
            package_description = PackageDescription;
        }
        public string reference_image { get; set; }
        public string package_description { get; set; }
    }
}

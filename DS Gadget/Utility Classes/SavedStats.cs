using System.Reflection;

namespace DS_Gadget
{
    class SavedStats
    {
        [Control("txtName")]
        public string Name { get; set; }
        [Control("cmbSex")]
        public int? Sex { get; set; }
        [Control("cmbClass")]
        public int? Class { get; set; }
        [Control("cmbPhysique")]
        public int? Physique { get; set; }
        [Control("nudHumanity")]
        public decimal? Humanity { get; set; }
        [Control("nudSouls")]
        public decimal? Souls { get; set; }
        [Control("nudVit")]
        public decimal? Vit { get; set; }
        [Control("nudAtt")]
        public decimal? Att { get; set; }
        [Control("nudEnd")]
        public decimal? End { get; set; }
        [Control("nudStr")]
        public decimal? Str{ get; set; }
        [Control("nudDex")]
        public decimal? Dex { get; set; }
        [Control("nudRes")]
        public decimal? Res { get; set; }
        [Control("nudInt")]
        public decimal? Int { get; set; }
        [Control("nudFth")]
        public decimal? Fth { get; set; }
        [Control("cmbCovenant")]
        public int? Covenant { get; set; }
        [Control("nudCovChaos")]
        public decimal? CovChaos { get; set; }
        [Control("nudCovDarkmoon")]
        public decimal? CovDarkmoon { get; set; }
        [Control("nudCovDarkwraith")]
        public decimal? CovDarkwraith { get; set; }
        [Control("nudCovForest")]
        public decimal? CovForest { get; set; }
        [Control("nudCovGravelord")]
        public decimal? CovGravelord { get; set; }
        [Control("nudCovDragon")]
        public decimal? CovDragon { get; set; }
        [Control("nudCovSunlight")]
        public decimal? CovSunlight { get; set; }

        public object this[string attributeName]
        {
            get
            {
                var props = typeof(SavedStats).GetProperties();
                foreach (var prop in props)
                {
                    var Attr = prop.GetCustomAttribute<ControlAttribute>();
                    if (Attr != null && Attr.Name == attributeName)
                        return prop.GetValue(this, null);
                }
                return null;
            }
            set
            {
                var props = typeof(SavedStats).GetProperties();
                foreach (var prop in props)
                {
                    var Attr = prop.GetCustomAttribute<ControlAttribute>();
                    if (Attr != null && Attr.Name == attributeName)
                        prop.SetValue(this, value, null);
                }
            }
        }
    }
}

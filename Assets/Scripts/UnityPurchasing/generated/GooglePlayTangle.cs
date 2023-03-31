// WARNING: Do not modify! Generated file.

namespace UnityEngine.Purchasing.Security {
    public class GooglePlayTangle
    {
        private static byte[] data = System.Convert.FromBase64String("XFzf7dy+o1c1KCpe3nKQZuwXrupWY0FPG4ijdudakXtGDlGrCkW4ACKQ7gblKQPIyTuJW+ZbIEao3gbFRQqfcvC7lbWgJzwuGBF10mWh6ShBwszD80HCycFBwsLDV9QmEIZLM/NBwuHzzsXK6UWLRTTOwsLCxsPAUQJowMqWTuRWqfOXrqXNFwKNzHVG/9cT2of9xWMNyH45DVaU4671K9BStr2ncUNV3x+XFiLejKw5macmUtnnPxi4RdEYjXcrAhvckI4XkUJ+CtTLh1oBw44e8Ta8HHVF+075hbzLc7UrBV5L6JQ0eZyxAcNohme3GRWZQTEHsQdkgDFv5TNSmcmjtPnJ51VnPANm2ZU685OddO3XwUM+PGTKEC9vEkpE+sHAwsPC");
        private static int[] order = new int[] { 13,2,9,11,9,13,8,9,10,9,10,11,13,13,14 };
        private static int key = 195;

        public static readonly bool IsPopulated = true;

        public static byte[] Data() {
        	if (IsPopulated == false)
        		return null;
            return Obfuscator.DeObfuscate(data, order, key);
        }
    }
}

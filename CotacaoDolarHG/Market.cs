using Newtonsoft.Json;

namespace CotacaoDolarHG
{
    public  class Market
    {
        [JsonProperty(PropertyName = "currencies")]
        public Currency Currency { get; set; }

        public Market()
        {
            this.Currency = new Currency();
        }
    }
}

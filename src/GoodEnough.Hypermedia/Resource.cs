using Newtonsoft.Json;

namespace GoodEnough.Hypermedia
{
    public abstract class Resource
    {
        public abstract string GetMediaType();
    }
}
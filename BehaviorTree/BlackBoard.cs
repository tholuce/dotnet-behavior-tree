using BehaviorTree.Interfaces;

namespace BehaviorTree
{
    public class BlackBoard : IBlackBoard
    {
        private readonly IDictionary<string, object> _data;
        public BlackBoard()
        {
            _data = new Dictionary<string, object>();
        }

        public T GetValue<T>(string keyName)
        {

            if (!_data.TryGetValue(keyName, out object objValue))
            {
                return default;
            }
            return (T)objValue;
        }

        public void SetValue<T>(string keyName, T value)
        {
            _data[keyName] = value;
        }
    }
}

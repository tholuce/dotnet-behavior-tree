

namespace BehaviorTree.Interfaces
{
    public interface IBlackBoard {

        void SetValue<T>(string keyName, T value);
        T GetValue<T>(string keyName);
    }
}
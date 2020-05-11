using System.Collections.Generic;
using System.Linq;

namespace TreeDataModel
{
    /// <summary>
    /// 树形结构数据存储
    /// </summary>
    public class DictionaryModel
    {
        public DictionaryModel()
        {
            _ChildList = new List<DictionaryModel>();
        }

        /// <summary>
        /// 根据ChildList中Key获取对象
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public DictionaryModel this[int key]
        {
            get
            {
                if (_ChildList.Count > key && key >= 0)
                    return _ChildList.Where(p => p.Key == key).ToArray()[0];
                else
                    return null;
            }
        }

        #region >>Property
        private IList<DictionaryModel> _ChildList;
        public IList<DictionaryModel> ChildList
        {
            get
            {
                return _ChildList;
            }
        }

        private int _Key;
        public int Key
        {
            get
            {
                return _Key;
            }
            set
            {
                _Key = value;
            }
        }

        private int _Value;
        public int Value
        {
            get
            {
                return _Value;
            }
        }
        #endregion

        #region >>Method
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void SetKeyValue(int key, int value)
        {
            _Key = key;
            _Value = value;
        }
        #endregion
    }
}

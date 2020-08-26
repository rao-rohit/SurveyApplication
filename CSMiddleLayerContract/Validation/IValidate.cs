using System;
using System.Collections.Generic;
using System.Text;

namespace CSMiddleLayerContract.Validation
{
    public interface IValidate<T>
    {
        /// <summary>
        /// bool - It will contain true or false based on validation rules on entity
        /// IEnumerable<String>  - It will contain Error messages
        /// </summary>
        /// <param name="entity">Enity</param>
        /// <returns></returns>
        (bool, IEnumerable<String>) Validate(T entity);
    }
}

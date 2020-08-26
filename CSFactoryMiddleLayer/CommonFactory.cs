using System;
using System.Collections.Generic;
using System.Text;
using Unity;
using CSMiddleLayerContract;
using CSMiddleLayer;
using Unity.Injection;
using CSMiddleLayerValidation;

namespace CSFactoryMiddleLayer
{
    //Factory class to generate required instances. We are using Unity container in it.
    public static class CommonFactory<T>
    {
        #region Fields
        private static IUnityContainer container = null;
        #endregion

        #region Constructor
        ///Registering dependencies, We can register singleton dependencies also for our utility things like logging, connection etc
        static CommonFactory()
        {
            container = new UnityContainer();
            //we are registering dependencies with the required validation rules. For a single entity we can have mltiple records with different name and validation rules
            container.RegisterType<IUser, User>("UserAuth", new InjectionConstructor(new UserAuthentication()));
            container.RegisterType<ISurvey, Survey>("AddEditSurvey", new InjectionConstructor(new AddEditSurvey()));
            container.RegisterType<IUser, User>("AddEditQuestion", new InjectionConstructor(new UserAuthentication()));
            container.RegisterType<ISurveyResponse, SurveyResponse>("SurveyResponse", new InjectionConstructor(new SubmitSurvey()));
        }

        #endregion

        #region Methods
        /// <summary>
        /// This method is use to return the intance of our required entity. 
        /// </summary>
        /// <param name="typeOfEntity"></param>
        /// <returns></returns>
        public static T Create(string typeOfEntity)
        {
            return container.Resolve<T>(typeOfEntity);
        }
        #endregion
    }
}

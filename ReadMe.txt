1. CSMiddleLayerContract - Project that is used for creating contract for entities & Validation
2. CSMiddleLayerValidation - Validation rules for entities - Used as Strategy pattern
3. CSMiddleLayer - Entites POCO and implements CSMiddleLayerContract, Implements IValidation<T>
4. CSFactoryMiddleLayer - Factory to create instance of entities using Unity container, Registered Dependencies in unity and resolve it based on key
5. CSDALContract - Contarct for our DAL
6. CSDALBase - Base class for all the DAL technologies
7. CSAdoNetDAL - Adonet base class for ADODotNet Implementation, It implements DAL base class. UOW can be used here to Implement CRUD operation on Entities
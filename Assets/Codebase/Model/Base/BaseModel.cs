namespace Assets.Codebase.Model.Base
{
    public abstract class BaseModel
    {
        public BaseModel()
        {
            InitModel();
        }

        protected abstract void InitModel();
    }
}

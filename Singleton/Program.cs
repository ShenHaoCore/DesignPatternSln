using Singleton;

SingleObject01 single01 = SingleObject01.GetInstance();
single01.ShowMessage();

SingleObject02? single02 = SingleObject02.GetInstance;
ArgumentNullException.ThrowIfNull(single02);
single02.ShowMessage();

SingleObject03? single03 = SingleObject03.GetInstance;
ArgumentNullException.ThrowIfNull(single03);
single03.ShowMessage();


SingleObject04 single04 = SingleObject04.Instance;
single04.ShowMessage();
namespace Enferia {
    using System;
    using System.Collections.Generic;
    using Caliburn.Micro;
    using Enferia.ViewModels;
    using System.ComponentModel;

    public class AppBootstrapper : BootstrapperBase {
        SimpleContainer container;

        public AppBootstrapper() {
            Initialize();
        }

        protected override void Configure() {
            container = new SimpleContainer();

            container.Singleton<IWindowManager, WindowManager>();
            container.Singleton<IEventAggregator, EventAggregator>();
            container.PerRequest<MainWindowViewModel>();
            container.PerRequest<LoginPageViewModel>();
            container.PerRequest<RegistrationPageViewModel>();
            container.PerRequest<StartUpViewModel>();
        }

        protected override object GetInstance(Type service, string key) {
            return container.GetInstance(service, key);
        }

        protected override IEnumerable<object> GetAllInstances(Type service) {
            return container.GetAllInstances(service);
        }

        protected override void BuildUp(object instance) {
            container.BuildUp(instance);
        }

        protected override void OnStartup(object sender, System.Windows.StartupEventArgs e) {
            DisplayRootViewFor<MainWindowViewModel>();
        }
        
    }
}
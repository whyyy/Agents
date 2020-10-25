using System.IO;
using Agents.Infrastructure.DataLoaders;
using Agents.Infrastructure.Generators;
using Agents.Models;
using Autofac;

namespace Agents.Infrastructure.Autofac
{
    public class DependenciesRegistrant
    {
        private readonly ContainerBuilder _builder;

        public DependenciesRegistrant()
        {
            _builder = new ContainerBuilder();
        }

        public void RegisterDependencies()
        {
            RegisterModels();
            _builder.Build();
        }

        private void RegisterModels()
        {
            _builder.RegisterType<KeyCard>().As<IKeyCard>();
            _builder.RegisterType<Agent>().As<IAgent>();
            _builder.RegisterType<Word>().As<IWord>();
        }

        private void RegisterInfrastructure()
        {
            _builder.RegisterType<FileLoader>().As<IFileLoader>();
            _builder.RegisterType<KeyCardGenerator>().As<IKeyCardGenerator>();
            _builder.RegisterType<AgentGenerator>().As<IAgentGenerator>();
        }
    }
}
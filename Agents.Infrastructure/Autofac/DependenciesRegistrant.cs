using Agents.Infrastructure.DataLoaders;
using Agents.Infrastructure.Generators;
using Agents.Infrastructure.Helpers;
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
            RegisterInfrastructure();
            _builder.Build();
        }

        private void RegisterModels()
        {
            _builder.RegisterType<KeyCard>().As<IKeyCard>();
            _builder.RegisterType<Agent>().As<IAgent>();
            _builder.RegisterType<Word>().As<IWord>();
            _builder.RegisterType<Board>().As<IBoard>();
        }

        private void RegisterInfrastructure()
        {
            _builder.RegisterType<FileLoader>().As<IFileLoader>();
            _builder.RegisterType<KeyCardGenerator>().As<IKeyCardGenerator>();
            _builder.RegisterType<AgentGenerator>().As<IAgentGenerator>();
            _builder.RegisterType<WordsLoader>().As<IWordsLoader>();
            _builder.RegisterType<StringListCreator>().As<IStringListCreator>();
            _builder.RegisterType<BoardGenerator>().As<IBoardGenerator>();
        }
    }
}
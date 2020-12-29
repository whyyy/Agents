using Agents.Infrastructure.DataLoaders;
using Agents.Infrastructure.Generators;
using Agents.Infrastructure.Helpers;
using Agents.Models;
using Autofac;
using Microsoft.Extensions.DependencyInjection;

namespace Agents.Infrastructure.Autofac
{
    public class DependenciesRegistrant
    {
        public void RegisterDependencies(ContainerBuilder builder)
        {
            RegisterModels(builder);
            RegisterInfrastructure(builder);
        }

        private void RegisterModels(ContainerBuilder builder)
        {
            builder.RegisterType<KeyCard>().As<IKeyCard>();
            builder.RegisterType<Agent>().As<IAgent>();
            builder.RegisterType<Word>().As<IWord>();
            builder.RegisterType<Board>().As<IBoard>();
        }

        private void RegisterInfrastructure(ContainerBuilder builder)
        {
            builder.RegisterType<FileLoader>().As<IFileLoader>();
            builder.RegisterType<KeyCardGenerator>().As<IKeyCardGenerator>();
            builder.RegisterType<AgentGenerator>().As<IAgentGenerator>();
            builder.RegisterType<WordsLoader>().As<IWordsLoader>();
            builder.RegisterType<StringListCreator>().As<IStringListCreator>();
            builder.RegisterType<BoardGenerator>().As<IBoardGenerator>();
        }
    }
}
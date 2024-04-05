using Domain;
using FluentAssertions;
using GenericDomain;
using MediatR;
using NetArchTest.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace ArchitecturTest.Doamin
{
    public class DomainTests
    {
        private static readonly Assembly DomainAssembly = typeof(DependancyInjection).Assembly;
        [Fact]
        public void ValueObject_Should_BeSealed()
        {
            var result = Types
                            .InAssembly(DomainAssembly)
                            .That()
                            .AreClasses()
                            .And()
                            .Inherit(typeof(ValueObject))
                            .Should()
                            .BeSealed()
                            .GetResult();

            result.FailingTypeNames.ToList().ForEach(Console.WriteLine);
            result.IsSuccessful.Should().BeTrue();
        }

        [Fact]
        public void Handler_Should_HaveHandlerAtTheEndOfItsName()
        {
            var result = Types
                            .InAssembly(DomainAssembly)
                            .That()
                            .AreClasses()
                            .And()
                            .ImplementInterface(typeof(IRequestHandler<,>))
                            .Should()
                            .HaveNameEndingWith("Handler")
                            .GetResult();
            result.IsSuccessful.Should().BeTrue();
        }
    }
}

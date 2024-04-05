using Domain;
using FluentAssertions;
using NetArchTest.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ArchitecturTest
{
    public class LayerTestscs
    {
        private static readonly Assembly DomainAssembly = typeof(DependancyInjection).Assembly;

        [Fact]
        public void DomianLayer_ShouldNot_DependantOnApplicationLayer()
        {
            Types
                .InAssembly(DomainAssembly)
                .Should()
                .NotHaveDependencyOn("Application")
                .GetResult()
                .IsSuccessful
                .Should()
                .BeTrue();
        }
    }
}

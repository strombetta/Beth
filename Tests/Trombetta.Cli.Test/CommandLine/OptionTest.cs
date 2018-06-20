using System;
using System.Linq;
using Trombetta.Cli.CommandLine;
using Xunit;
using Xunit.Abstractions;

namespace Trombetta.Cli.Test.CommandLine
{
   public class OptionTest
   {

      [Fact]
      public void SuccessfullyCreateOptionWithSingleAlias()
      {
         var option = new Option(new[] { "option" }, "");
         Assert.True(option.Name == "option");
      }

      [Fact]
      public void OptionCannotHaveEmptyAlias()
      {
         Action action = () => new Option(new[] { "" }, "");
         Assert.Throws<ArgumentException>(action);
      }

      [Fact]
      public void OptionHasMultipleAliases()
      {
         var option = new Option(new[] { "option", "opt", "o" }, "");
         Assert.True(option.Aliases.Count() == 3);
         Assert.True(option.Name == "option");
         Assert.True(option.Aliases.Contains("opt"));
         Assert.True(option.Aliases.Contains("o"));
      }

      [Fact]
      public void OptionAliasesAreCaseSensitive()
      {
         var option = new Option(new[] { "option", "o" }, "");
         Assert.True(option.Aliases.Count() == 2);
         Assert.True(option.Name == "option");
         Assert.True(option.Aliases.Contains("O") == false);
      }
   }
}

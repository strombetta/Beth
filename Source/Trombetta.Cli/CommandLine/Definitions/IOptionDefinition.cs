//
// Copyright (C) Sebastiano Trombetta. All rights reserved.
// Licensed under the MIT license. See LICENSE.md file in the project root for full license information.
//

using System;
using System.Collections.Generic;

namespace Trombetta.Cli.CommandLine.Definitions
{
   /// <summary>
   /// Represents an option definition.
   /// </summary>
   public interface IOptionDefinition
   {
      IArgumentDefinition Argument {get;}
      IOption MapToOption();      
      IEnumerable<String> Aliases { get; }
      Boolean IsArgumentRequired { get; }
   }
}
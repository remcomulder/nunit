// Copyright (c) Charlie Poole, Rob Prouse and Contributors. MIT License - see LICENSE.txt

namespace NUnit.Framework.Internal.Commands
{
    /// <summary>
    /// DelegatingTestCommand wraps an inner TestCommand.
    /// Derived classes may do what they like before or
    /// after running the inner command.
    /// </summary>
    public abstract class DelegatingTestCommand : TestCommand
    {
        /// <summary>TODO: Documentation needed for field</summary>
#pragma warning disable IDE1006
        // ReSharper disable once InconsistentNaming
        // Disregarding naming convention for back-compat
        protected TestCommand innerCommand;
#pragma warning restore IDE1006

        /// <summary>
        /// Initializes a new instance of the <see cref="DelegatingTestCommand"/> class.
        /// </summary>
        /// <param name="innerCommand">The inner command.</param>
        protected DelegatingTestCommand(TestCommand innerCommand)
            : base(innerCommand.Test)
        {
            this.innerCommand = innerCommand;
        }
    }
}

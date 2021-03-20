﻿using Microsoft.Extensions.Logging;
using System.Threading;
using System.Threading.Tasks;

namespace Grillisoft.DotnetTools.NewRepo.Creators.Impl
{
    public class GitAttributesCreator : CreatorBase
    {
        public const string Name = ".gitattributes";

        public GitAttributesCreator(
            NewRepoSettings options,
            ILogger<GitAttributesCreator> logger)
            : base(options, logger)
        {
        }

        public override async Task Create(CancellationToken cancellationToken)
        {
            await this.CreateTextFile(this.Root.File(Name), await GetTemplateContent(Name));
        }
    }
}
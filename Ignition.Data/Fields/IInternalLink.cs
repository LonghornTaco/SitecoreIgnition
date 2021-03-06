﻿using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using Ignition.Core.Models;

namespace Ignition.Data.Fields
{
    [SitecoreType(TemplateId = "{C330D166-687F-48C1-8FBC-47DE306D34D6}")]
    public interface IInternalLink : IModelBase
    {
        [SitecoreField(FieldId = "{DE3F5373-4370-4702-972D-CFD73F88EA63}")]
        Link InternalLink { get; set; }
    }
}
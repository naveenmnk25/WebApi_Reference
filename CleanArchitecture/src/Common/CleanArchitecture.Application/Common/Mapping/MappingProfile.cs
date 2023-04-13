using CleanArchitecture.Application.Dto;
using CleanArchitecture.Domain.Entities;
using Mapster;
using System;
using System.Linq;

namespace CleanArchitecture.Application.Common.Mapping
{
    public class MyRegister : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            //config.NewConfig<VersionMap, PreviewGridDto>()
            //    .Map(d => d, s => s)
            //    .Map(d => d.TableType, s => s.TableType.TableTypeName)
            //    .Map(d => d.Language, s => s.TableType.LanguageCode)
            //    .Map(d => d.Version, s => s.VersionName)
            //    .Map(d => d.ToolVersion, s => s.TableType.Company.ToolVersion)
            //    .Map(d => d.CompanyCode, s => s.TableType.Company.CompanyCode);

        }
    }
}

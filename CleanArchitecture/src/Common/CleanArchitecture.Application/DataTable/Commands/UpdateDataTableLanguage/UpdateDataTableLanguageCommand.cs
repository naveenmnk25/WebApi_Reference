using CleanArchitecture.Application.Common.Caching;
using CleanArchitecture.Application.Common.Interfaces;
using CleanArchitecture.Application.Common.Models;
using CleanArchitecture.Application.Dto;
using CleanArchitecture.Domain.Entities;
using MapsterMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.DataTable.Commands.UpdateDataTableLanguage
{
    public class UpdateDataTableLanguageCommand : IRequestWrapper<long[]>
    {
        public long? DataTableId { get; set; }
        public string TableName { get; set; }
        public List<DataTableLanguageLabelss> dataTableLanguageLabels { get; set; }

    }
    public class DataTableLanguageLabelss
    {
        public long? DataTableLabelId { get; set; }
        public string LabelName { get; set; }
        public string LanguageCode { get; set; }
        public int DataTableId { get; set; }
        public int LanguageId { get; set; }
        public int CompanyId { get; set; }
    }

    public class UpdateDataTableLanguageCommandHandler : IRequestHandlerWrapper<UpdateDataTableLanguageCommand, long[]>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly Caching _caching;

        public UpdateDataTableLanguageCommandHandler(IApplicationDbContext context, IMapper mapper, Caching caching)
        {
            _context = context;
            _mapper = mapper;
            _caching = caching;
        }

        public async Task<ServiceResult<long[]>> Handle(UpdateDataTableLanguageCommand request, CancellationToken cancellationToken)
        {
            long?[] ids = null;
            var tableId = request.DataTableId;
            if (request.dataTableLanguageLabels.Count > 0)
            {
                var addDataTable = request.dataTableLanguageLabels.Where(x => x.DataTableLabelId == null && !string.IsNullOrEmpty(x.LabelName))
                    .Select(s => new DataTableLabel() { DataTableId = tableId, TableName = s.LabelName, LanguageCode = s.LanguageCode }).ToArray();
                _context.DataTableLabel.AddRange(addDataTable);
                await _context.SaveChangesAsync(cancellationToken);
                ids = addDataTable.Select(s => s.DataTableLabelId).ToArray();

                var updateDataTable = request.dataTableLanguageLabels.Where(x => x.DataTableLabelId != null)
                    .Select(s => new DataTableLabel() { DataTableId = tableId, TableName = s.LabelName, LanguageCode = s.LanguageCode, DataTableLabelId = s.DataTableLabelId , CreatedDate = DateTime.Now});
                _context.DataTableLabel.UpdateRange(updateDataTable);
                await _context.SaveChangesAsync(cancellationToken);
            }
            return ServiceResult.Success(_mapper.Map<long[]>(ids));
        }
    }
}

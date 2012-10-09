//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the Rock.CodeGeneration project
//     Changes to this file will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
//
// THIS WORK IS LICENSED UNDER A CREATIVE COMMONS ATTRIBUTION-NONCOMMERCIAL-
// SHAREALIKE 3.0 UNPORTED LICENSE:
// http://creativecommons.org/licenses/by-nc-sa/3.0/
//

using System;
using System.Linq;

using Rock.Data;

namespace Rock.Core
{
    /// <summary>
    /// FieldType Service class
    /// </summary>
    public partial class FieldTypeService : Service<FieldType, FieldTypeDto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldTypeService"/> class
        /// </summary>
        public FieldTypeService()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FieldTypeService"/> class
        /// </summary>
        public FieldTypeService(IRepository<FieldType> repository) : base(repository)
        {
        }

        /// <summary>
        /// Creates a new model
        /// </summary>
        public override FieldType CreateNew()
        {
            return new FieldType();
        }

        /// <summary>
        /// Query DTO objects
        /// </summary>
        /// <returns>A queryable list of DTO objects</returns>
        public override IQueryable<FieldTypeDto> QueryableDto( )
        {
            return QueryableDto( this.Queryable() );
        }

        /// <summary>
        /// Query DTO objects
        /// </summary>
        /// <returns>A queryable list of DTO objects</returns>
        public IQueryable<FieldTypeDto> QueryableDto( IQueryable<FieldType> items )
        {
            return items.Select( m => new FieldTypeDto()
                {
                    IsSystem = m.IsSystem,
                    Name = m.Name,
                    Description = m.Description,
                    Assembly = m.Assembly,
                    Class = m.Class,
                    CreatedDateTime = m.CreatedDateTime,
                    ModifiedDateTime = m.ModifiedDateTime,
                    CreatedByPersonId = m.CreatedByPersonId,
                    ModifiedByPersonId = m.ModifiedByPersonId,
                    Id = m.Id,
                    Guid = m.Guid,
                });
        }
    }
}

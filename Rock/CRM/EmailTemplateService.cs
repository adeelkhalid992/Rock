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

namespace Rock.Crm
{
    /// <summary>
    /// EmailTemplate Service class
    /// </summary>
    public partial class EmailTemplateService : Service<EmailTemplate, EmailTemplateDto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailTemplateService"/> class
        /// </summary>
        public EmailTemplateService()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailTemplateService"/> class
        /// </summary>
        public EmailTemplateService(IRepository<EmailTemplate> repository) : base(repository)
        {
        }

        /// <summary>
        /// Creates a new model
        /// </summary>
        public override EmailTemplate CreateNew()
        {
            return new EmailTemplate();
        }

        /// <summary>
        /// Query DTO objects
        /// </summary>
        /// <returns>A queryable list of DTO objects</returns>
        public override IQueryable<EmailTemplateDto> QueryableDto( )
        {
            return QueryableDto( this.Queryable() );
        }

        /// <summary>
        /// Query DTO objects
        /// </summary>
        /// <returns>A queryable list of DTO objects</returns>
        public IQueryable<EmailTemplateDto> QueryableDto( IQueryable<EmailTemplate> items )
        {
            return items.Select( m => new EmailTemplateDto()
                {
                    IsSystem = m.IsSystem,
                    PersonId = m.PersonId,
                    Category = m.Category,
                    Title = m.Title,
                    From = m.From,
                    To = m.To,
                    Cc = m.Cc,
                    Bcc = m.Bcc,
                    Subject = m.Subject,
                    Body = m.Body,
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

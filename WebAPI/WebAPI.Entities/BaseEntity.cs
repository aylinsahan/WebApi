using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using WebAPI.Entities.Interface;

namespace WebAPI.Entities
{
    public class BaseEntity<TKey> : IBaseEntity<TKey>
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public TKey Id { get; set; }
    }
}

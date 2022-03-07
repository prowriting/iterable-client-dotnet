using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Armut.Iterable.Client.Models.Base;

namespace Armut.Iterable.Client.Models.EventModels
{
    public class InAppConsumeRequest: EventTrackInAppBaseRequest
    {
        public string DeleteAction { get; set; }
    }

}

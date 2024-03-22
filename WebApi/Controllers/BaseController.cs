using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

public class BaseController:ControllerBase
{
    private IMediator? _mediator;

    //Eğer daha önce inject edilmişse onu döndür null ise IOCden al ve set et
    protected IMediator? Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();

}

using API.Dtos;
using API.Helpers.Errors;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
namespace API.Controllers;

[ApiVersion("1.0")]
[ApiVersion("1.1")]

[Route("[controller]")]
public class TeamDriverController : ControllerBase
{
    private readonly IUnitOfWork unitOfWork;
    private readonly IMapper mapper;

    public TeamDriverController(IUnitOfWork unitOfWork, IMapper mapper)
    {
        this.unitOfWork = unitOfWork;
        this.mapper = mapper;
    }

    [HttpGet]
    [MapToApiVersion("1.0")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<TeamDriverDto>>> Get()
    {
        var data = await unitOfWork.TeamDrivers.GetAllAsync();
        return mapper.Map<List<TeamDriverDto>>(data);
    }

    [HttpGet("Pagination")]
    [MapToApiVersion("1.1")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Pager<TeamDriverDto>>> GetPagination([FromQuery] Params dataParams)
    {
        var datos = await unitOfWork.TeamDrivers.GetAllAsync(dataParams.PageIndex, dataParams.PageSize, dataParams.Search);
        var listData = mapper.Map<List<TeamDriverDto>>(datos.registros);
        return new Pager<TeamDriverDto>(listData, datos.totalRegistros, dataParams.PageIndex, dataParams.PageSize, dataParams.Search);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<TeamDriverDto>> Post(TeamDriverDto dataDto)
    {
        var data = mapper.Map<TeamDriver>(dataDto);
        unitOfWork.TeamDrivers.Add(data);
        try
        {
            await unitOfWork.SaveAsync();
            return CreatedAtAction(nameof(Post), new { /* información para la respuesta */ }, dataDto);
        }
        catch (Exception ex)
        {
            return BadRequest("Error al crear el registro: " + ex.Message);
        }
    }

    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<TeamDriverDto>> Put(int id, [FromBody] TeamDriverDto dataDto)
    {
        if (dataDto == null)
        {
            return NotFound();
        }
        var existingData = await unitOfWork.TeamDrivers.GetByIdAsync(id);
        if (existingData == null)
        {
            return NotFound();
        }
        mapper.Map(dataDto, existingData);
        unitOfWork.TeamDrivers.Update(existingData);
        await unitOfWork.SaveAsync();
        return dataDto;
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id)
    {
        var existingData = await unitOfWork.TeamDrivers.GetByIdAsync(id);
        if (existingData == null)
        {
            return NotFound();
        }
        unitOfWork.TeamDrivers.Remove(existingData);
        await unitOfWork.SaveAsync();
        return NoContent();
    }
}
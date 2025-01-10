namespace foodtopia.DTOs.Instruction
{
    public record InstructionDTO
    (
        Guid Id,
        string Step,
        int Order
    );
}
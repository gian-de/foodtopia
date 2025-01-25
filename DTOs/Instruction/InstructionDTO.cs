namespace foodtopia.DTOs.Instruction
{
    public record InstructionDTO
    (
        Guid Id,
        int Order,
        string Text
    );
}
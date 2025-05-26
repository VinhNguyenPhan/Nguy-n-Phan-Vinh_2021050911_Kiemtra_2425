// 3 thuoc tinh khac nhau, 1thuov tinh lam kh
using System.ComponentModel.DataAnnotations;
namespace NGUYENPHANVINH_2021050911_KiemTra.Models;
public class K2
{
    public string? FullName {get;set;}
    public int? SDT {get; set;}
    [Key]
    public string? DiaChi {get; set;}
}
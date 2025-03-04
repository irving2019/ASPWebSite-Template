using System.ComponentModel.DataAnnotations;

namespace ASPWebSite.Models
{
    public class Contact
    {
        [Display(Name = "Введите Имя")]
        [Required(ErrorMessage = "Не корректный ввод")]
        public string Name { get; set; }

        [Display(Name = "Введите Фамилию")]
        [Required(ErrorMessage = "Не корректный ввод")]
        public string SurName { get; set; }

        [Display(Name = "Введите Возраст")]
        [Required(ErrorMessage = "Не корректный ввод")]
        public int Age { get; set; }

        [Display(Name = "Введите e-mail")]
        [Required(ErrorMessage = "Не корректный ввод")]
        public string Email { get; set; }

        [Display(Name = "Введите Сообщение")]
        [StringLength(30, ErrorMessage = "Не меньше 30 символов")]
        [Required(ErrorMessage = "Не корректный ввод")]
        public string Message { get; set; }

    }
}

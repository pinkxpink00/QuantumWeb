using AutoMapper;
using System.Reflection;
using System.Linq;

namespace Notes.Application.Common.Mappings
{
    // Клас AssemblyMappingProfile реалізує профіль AutoMapper для автоматичного встановлення відображень з вказаної збірки.
    public class AssemblyMappingProfile : Profile
    {
        public AssemblyMappingProfile(Assembly assembly) =>
            ApplyMappingsFromAssembly(assembly);

        private void ApplyMappingsFromAssembly(Assembly assembly)
        {
            // Отримати всі видимі (експортовані) типи з вказаної збірки.
            var types = assembly.GetExportedTypes()
                .Where(type => type.GetInterfaces()
                 .Any(i => i.IsGenericType &&
                 i.GetGenericTypeDefinition() == typeof(IMapWith<>)))
                .ToList();

            foreach (var type in types)
            {
                // Створити екземпляр типу.
                var instance = Activator.CreateInstance(type);

                // Отримати метод "Mapping" для налаштування відображення.
                var methodInfo = type.GetMethod("Mapping");

                // Викликати метод "Mapping" для встановлення відображення для поточного профілю.
                methodInfo?.Invoke(instance, new object[] { this });
            }
        }
    }
}
using AutoMapper;

namespace Notes.Application.Common.Mappings
{
    // Інтерфейс IMapWith<T> визначає метод для налаштування відображення між типами.
    public interface IMapWith<T>
    {
        // Метод Mapping приймає об'єкт Profile з AutoMapper і встановлює відображення між типами T та поточним типом.
        void Mapping(Profile profile) =>
            profile.CreateMap(typeof(T), GetType());
    }
}
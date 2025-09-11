// =======================
// Flyweight Pattern Demo
// =======================
//
// In this example, we model "Book" objects.
// - The shared state (intrinsic state) is Title, Author, ISBN.
// - The external state (extrinsic state) is InventoryId (different for each copy).
//
// The idea of the Flyweight Pattern: 
// Instead of creating multiple identical objects (e.g., many "Harry Potter"),
// we create one shared object and reuse it across the program.
//
// =======================

using System;
using System.Collections.Concurrent;

namespace Flyweight
{
    // -----------------------
    // Flyweight interface
    // -----------------------
    // Defines the operations that all Book objects must have.
    public interface IBook
    {
        string Title { get; }
        string Author { get; }
        string ISBN { get; }
        void Display(int inventoryId); // extrinsic state is passed in here
    }

    // -----------------------
    // Concrete Flyweight
    // -----------------------
    // A concrete implementation of IBook.
    // Here we use the C# 12 "primary constructor" syntax (requires .NET 8+).
    public class Book(string title, string author, string isbn) : IBook
    {
        // Intrinsic state: shared, stored once
        public string Title { get; } = title;
        public string Author { get; } = author;
        public string ISBN { get; } = isbn;

        // Display also receives extrinsic state (inventoryId) at runtime
        public void Display(int inventoryId)
        {
            Console.WriteLine($"Inventory ID: {inventoryId}, Title: {Title}, Author: {Author}, ISBN: {ISBN}");
        }
    }

    // -----------------------
    // Flyweight Factory
    // -----------------------
    // Responsible for managing and caching flyweight objects.
    // - If a book with the same Title/Author/ISBN already exists, return the existing one.
    // - Otherwise, create it and add it to the cache.
    public class BookFactory
    {
        // Thread-safe dictionary to store cached books
        private readonly ConcurrentDictionary<string, IBook> _books = new();

        // Create a unique key from Title, Author, and ISBN
        private static string MakeKey(string title, string author, string isbn) =>
            $"{title}#{author}#{isbn}";

        // Get or create a book
        public IBook GetBook(string title, string author, string isbn)
        {
            var key = MakeKey(title, author, isbn);
            return _books.GetOrAdd(key, _ => new Book(title, author, isbn));
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItMyTaskClean.Domain.Entities;

public class Work
{
    private Work() { }
    private Work(Guid id, string nameTask, int taskNumber, string description, string customer, string adressTask, decimal price)
    {
        Id = id;
        NameTask = nameTask;
        TaskNumber = taskNumber;
        Description = description;
        Customer = customer;
        AdressTask = adressTask;
        Price = price;

    }
    public Guid Id { get; private set; }
    public string NameTask { get; private set; }
    public int TaskNumber { get; private set; }    
    public string Description { get; private set; }
    public string Customer {  get; private set; }
    public string AdressTask { get; private set; }
    public decimal Price { get; private set; }
    public static Work Create(Guid id, string nameTask, int taskNumber, string description, string customer, string adressTask, decimal price)
    {
        if(string.IsNullOrWhiteSpace(nameTask))
            throw new ArgumentException("NameTask can not be null or empty.", nameof(nameTask));

        if(taskNumber < 0)
            throw new ArgumentOutOfRangeException(nameof(taskNumber), "TaskNumber can not be begative.");

        if (string.IsNullOrWhiteSpace(description))
            throw new ArgumentException("NameTask can not be null or empty.", nameof(description));
        
        if (string.IsNullOrWhiteSpace(customer))
            throw new ArgumentException("Customer can not be null or empty", nameof(customer));

        if (string.IsNullOrWhiteSpace(adressTask))
            throw new ArgumentException("Customer can not be null or empty", nameof(adressTask));
        
        if (price < 0)
            throw new ArgumentOutOfRangeException(nameof(price), "Price can not be begative.");

        return new Work(id, nameTask, taskNumber, description, customer, adressTask, price);
    }
    public void Update(string nameTask, int taskNumber, string description, string customer, string adressTask, decimal price)
    {
        if (string.IsNullOrWhiteSpace(nameTask))
            throw new ArgumentException("NameTask can not be null or empty.", nameof(nameTask));

        if (taskNumber < 0)
            throw new ArgumentOutOfRangeException(nameof(taskNumber), "TaskNumber can not be begative.");

        if (string.IsNullOrWhiteSpace(description))
            throw new ArgumentException("NameTask can not be null or empty.", nameof(description));

        if (string.IsNullOrWhiteSpace(customer))
            throw new ArgumentException("Customer can not be null or empty", nameof(customer));

        if (string.IsNullOrWhiteSpace(adressTask))
            throw new ArgumentException("Customer can not be null or empty", nameof(adressTask));

        if (price < 0)
            throw new ArgumentOutOfRangeException(nameof(price), "TaskNumber can not be begative.");

        NameTask = nameTask;
        TaskNumber = taskNumber;
        Description = description;
        Customer = customer;
        AdressTask = adressTask;
        Price = price;
    }
}

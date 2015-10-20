# Database Systems - Overview

---

1. What database models do you know?
-----

A database model is a type of data model that determines the logical structure of a database and fundamentally determines in which manner data can be stored, organized, and manipulated. The most popular example of a database model is the relational model, which uses a table-based format.
Common logical data models for databases include:

* [Hierarchical database model](https://en.wikipedia.org/wiki/Hierarchical_database_model)
* [Network model](https://en.wikipedia.org/wiki/Network_model)
* [Relational model](https://en.wikipedia.org/wiki/Relational_model)
* [Entity–relationship model](https://en.wikipedia.org/wiki/Entity%E2%80%93relationship_model)
    * [Enhanced entity–relationship model](https://en.wikipedia.org/wiki/Enhanced_entity%E2%80%93relationship_model)
* [Object model](https://en.wikipedia.org/wiki/Object_database)
* [Document model](https://en.wikipedia.org/wiki/Document-oriented_database)
* [Entity–attribute–value model](https://en.wikipedia.org/wiki/Entity%E2%80%93attribute%E2%80%93value_model)
* [Star schema](https://en.wikipedia.org/wiki/Star_schema)


***

2. Which are the main functions performed by a Relational Database Management System (RDBMS)?
-----

A relational database management system (RDBMS) is a program that lets you create, update, and administer a relational database. Most commercial RDBMS's use the Structured Query Language (SQL) to access the database, although SQL was invented after the development of the relational model and is not necessary for its use.

Main functions performed by RDBMS:

* Creating / altering / deleting tables and relationships between them (database schema)

* Adding, changing, deleting, searching and retrieving of data stored in the tables

***

3. Define what is "table" in database terms.
-----

A table is a collection of related data held in a structured format within a database. It consists of fields (columns), and rows.

In [relational databases](https://en.wikipedia.org/wiki/Relational_database) and [flat file databases](https://en.wikipedia.org/wiki/Flat_file_database), a **table** is a set of data elements (values) using a model of vertical columns (identifiable by name) and horizontal rows, the cell being the unit where a row and column intersect. A table has a specified number of columns, but can have any number of rows. Each row is identified by one or more values appearing in a particular column subset. The columns subset which uniquely identifies a row is called the primary key.

"Table" is another term for "relation"; although there is the difference in that a table is usually a multiset (bag) of rows where a relation is a set and does not allow duplicates. Besides the actual data rows, tables generally have associated with them some metadata, such as constraints on the table or on the values within particular columns.

The data in a table does not have to be physically stored in the database. Views also function as relational tables, but their data are calculated at query time. External tables (in Informix or Oracle, for example) store data outside standard database structures but accessible to database commands.

***

4. Explain the difference between a primary and a foreign key.
-----

**Foreign keys** are used to reference unique columns in another table. So, for example, a foreign key can be defined on one table A, and it can reference some unique column(s) in another table B. Why would you want a foreign key? Well, whenever it makes sense to have a relationship between columns in two different tables.

A table can have multiple **unique** and **foreign keys**. However, a table can have only one **primary key**.

***

5. Explain the different kinds of relationships between tables in relational databases.
-----

Relationship types
You share many relationships with members of your family. For instance, you and your mother are related. You have only one mother, but she may have several children. You and your siblings are related—you may have many brothers and sisters and, of course, they'll have many brothers and sisters as well. If you're married, both you and your spouse have a spouse—each other—but only one at a time. Database relationships are very similar in that they're associations between tables. There are three types of relationships:

* __One-to-one__: Both tables can have only one record on either side of the relationship. Each primary key value relates to only one (or no) record in the related table. They're like spouses—you may or may not be married, but if you are, both you and your spouse have only one spouse. Most one-to-one relationships are forced by business rules and don't flow naturally from the data. In the absence of such a rule, you can usually combine both tables into one table without breaking any normalization rules.
* __One-to-many__: The primary key table contains only one record that relates to none, one, or many records in the related table. This relationship is similar to the one between you and a parent. You have only one mother, but your mother may have several children.
* __Many-to-many__: Each record in both tables can relate to any number of records (or no records) in the other table. For instance, if you have several siblings, so do your siblings (have many siblings). Many-to-many relationships require a third table, known as an associate or linking table, because relational systems can't directly accommodate the relationship.

***

6. When is a certain database schema normalized?
-----
    * What are the advantages of normalized databases?
------

Database normalization (or normalisation) is the process of organizing the columns (attributes) and tables (relations) of a relational database to minimize data redundancy.

Normalization involves decomposing a table into less redundant (and smaller) tables without losing information; defining foreign keys in the old table referencing the primary keys of the new ones. The objective is to isolate data so that additions, deletions, and modifications of an attribute can be made in just one table and then propagated through the rest of the database using the defined foreign keys.

***

7. What are database integrity constraints and when are they used?
-----

Integrity constraints provide a mechanism for ensuring that data conforms to guidelines specified by the database administrator. The most common types of constraints include:

* UNIQUE constraints

    To ensure that a given column is unique

* NOT NULL constraints

    To ensure that no null values are allowed

* FOREIGN KEY constraints

    To ensure that two keys share a primary key to foreign key relationship

Constraints can be used for these purposes in a data warehouse:

* Data cleanliness

    Constraints verify that the data in the data warehouse conforms to a basic level of data consistency and correctness, preventing the introduction of dirty data.

* Query optimization

    The Oracle Database utilizes constraints when optimizing SQL queries. Although constraints can be useful in many aspects of query optimization, constraints are particularly important for query rewrite of materialized views.

Unlike data in many relational database environments, data in a data warehouse is typically added or modified under controlled circumstances during the extraction, transformation, and loading (ETL) process. Multiple users normally do not update the data warehouse directly, as they do in an OLTP system.

***

8. Point out the pros and cons of using indexes in a database.
-----

**Advantages**: Use an index for quick access to a database table specific information. The index is a structure of the database table the value of one or more columns to sort
As a general rule, only when the data in the index column Frequent queries, only need to create an index on the table. The index take up disk space and reduce to add, delete, and update the line speed. In most cases, the speed advantages of indexes for data retrieval greatly exceeds it. 

**Disadvantages**: Index will affect the speed of update and insert, because it requires the same update each index file. For a frequently updated and inserted into the table, there is no need for a rarely used where the words indexed separately, small table, the cost of sorting will not be great, there is no need to create additional indexes. In some cases, the indexing words may not be fast, for example, the index is placed in a contiguous memory space, which will increase the burden of disk read, which is optimal, it should be through the actual use of the environment to be tested.

[More about indexes](http://www.databaseskill.com/3082411/)

***

9. What's the main purpose of the SQL language?
-----

SQL language is originally based upon relational algebra and tuple relational calculus, SQL consists of a data definition language, data manipulation language, and a data control language. The scope of SQL includes data insert, query, update and delete, schema creation and modification, and data access control. Although SQL is often described as, and to a great extent is, a declarative language (4GL), it also includes procedural elements.

SQL was one of the first commercial languages for Edgar F. Codd's relational model, as described in his influential 1970 paper, "A Relational Model of Data for Large Shared Data Banks."[10] Despite not entirely adhering to the relational model as described by Codd, it became the most widely used database language.

***

10. What are transactions used for?
-----
    * Give an example.
------

A transaction is a unit of work that is performed against a database. Transactions are units or sequences of work accomplished in a logical order, whether in a manual fashion by a user or automatically by some sort of a database program.

A transaction is the propagation of one or more changes to the database. For example, if you are creating a record or updating a record or deleting a record from the table, then you are performing transaction on the table. It is important to control transactions to ensure data integrity and to handle database errors.

There are following commands used to control transactions:

* COMMIT: to save the changes.

* ROLLBACK: to rollback the changes.

* SAVEPOINT: creates points within groups of transactions in which to ROLLBACK

* SET TRANSACTION: Places a name on a transaction.

Transactional control commands are only used with the DML commands INSERT, UPDATE and DELETE only. They can not be used while creating tables or dropping them because these operations are automatically commited in the database.

11. What is a NoSQL database?
-----

NoSQL encompasses a wide variety of different database technologies that were developed in response to a rise in the volume of data stored about users, objects and products, the frequency in which this data is accessed, and performance and processing needs. Relational databases, on the other hand, were not designed to cope with the scale and agility challenges that face modern applications, nor were they built to take advantage of the cheap storage and processing power available today.

***

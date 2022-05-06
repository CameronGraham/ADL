# ADL Practical Assessment

Before running for first time, run update-database in nuGet Package Manager Console to build database and seed dummy data.

There are 3 pages, main page holds the form, /getrecords holds a table with the records pulled from database, accessing this page will also generate an XML file in the wwwroot directory (requests.xml)

Hidden page /requests holds a JSON feed of the same data.

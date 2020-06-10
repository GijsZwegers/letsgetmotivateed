
\connect plannerdb


CREATE TABLE tasks
(
    id serial PRIMARY KEY,
    name  VARCHAR (50)  NOT NULL,
    description  VARCHAR (100)  NOT NULL,
    startdate  timestamp ,
    finisheddate  timestamp,  
    planneddate  timestamp  
);

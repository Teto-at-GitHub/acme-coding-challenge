CREATE USER acme
WITH
LOGIN
SUPERUSER
CREATEDB
CREATEROLE
INHERIT
NOREPLICATION
CONNECTION LIMIT -1
PASSWORD 'acme';

CREATE DATABASE acmedb
    WITH
    OWNER = acme
ENCODING = 'UTF8'
    LC_COLLATE = 'en_US.utf8'
    LC_CTYPE = 'en_US.utf8'
    TABLESPACE = pg_default
    CONNECTION LIMIT = -1;

\connect acmedb

CREATE SCHEMA IF NOT EXISTS "acme"
    AUTHORIZATION postgres;


CREATE TABLE
IF NOT EXISTS "acme"."warehouse"
(
    id serial PRIMARY KEY,
    friendly_id text,
    maximum_capacity integer
);


CREATE TABLE
IF NOT EXISTS "acme"."product"
(
   id serial PRIMARY KEY,
   name text,
   description text,
   price integer,
   guid text,
   danger text,
   warehouse_id integer
);

CREATE TABLE
IF NOT EXISTS "acme"."picture"
(
    id serial PRIMARY KEY,
    product_id integer,
    pictureUrl text
);

CREATE TABLE
IF NOT EXISTS "acme"."location"
(
    id serial PRIMARY KEY,
    street text,
    streetNr integer,
    city text,
    country text,
    zipcode text
);

ALTER TABLE
IF EXISTS "acme"."product"
    OWNER to acme;

ALTER TABLE
IF EXISTS "acme"."warehouse"
    OWNER to acme;

ALTER TABLE
IF EXISTS "acme"."location"
    OWNER to acme;

ALTER TABLE
IF EXISTS "acme"."picture"
    OWNER to acme;

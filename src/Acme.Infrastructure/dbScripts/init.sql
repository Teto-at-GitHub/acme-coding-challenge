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

CREATE DATABASE acme
    WITH
    OWNER = acme
ENCODING = 'UTF8'
    LC_COLLATE = 'en_US.utf8'
    LC_CTYPE = 'en_US.utf8'
    TABLESPACE = pg_default
    CONNECTION LIMIT = -1;

\connect acme

CREATE SCHEMA IF NOT EXISTS "Acme"
    AUTHORIZATION postgres;

CREATE TABLE
IF NOT EXISTS "Acme"."Product"
(
)

TABLESPACE pg_default;

ALTER TABLE
IF EXISTS "Acme"."Product"
    OWNER to acme;

--
-- PostgreSQL database dump
--

-- Dumped from database version 10.3
-- Dumped by pg_dump version 10.3

-- Started on 2018-03-12 03:52:26

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET client_min_messages = warning;
SET row_security = off;

--
-- TOC entry 2800 (class 1262 OID 16395)
-- Name: DesafioDB; Type: DATABASE; Schema: -; Owner: postgres
--

CREATE DATABASE "DesafioDB" WITH TEMPLATE = template0 ENCODING = 'UTF8' LC_COLLATE = 'Portuguese_Brazil.1252' LC_CTYPE = 'Portuguese_Brazil.1252';


ALTER DATABASE "DesafioDB" OWNER TO postgres;

\connect "DesafioDB"

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET client_min_messages = warning;
SET row_security = off;

--
-- TOC entry 1 (class 3079 OID 12924)
-- Name: plpgsql; Type: EXTENSION; Schema: -; Owner: 
--

CREATE EXTENSION IF NOT EXISTS plpgsql WITH SCHEMA pg_catalog;


--
-- TOC entry 2802 (class 0 OID 0)
-- Dependencies: 1
-- Name: EXTENSION plpgsql; Type: COMMENT; Schema: -; Owner: 
--

COMMENT ON EXTENSION plpgsql IS 'PL/pgSQL procedural language';


SET default_tablespace = '';

SET default_with_oids = false;

--
-- TOC entry 197 (class 1259 OID 16410)
-- Name: Customers; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Customers" (
    "Id" integer NOT NULL,
    "Name" character varying NOT NULL,
    "Email" character varying NOT NULL
);


ALTER TABLE public."Customers" OWNER TO postgres;

--
-- TOC entry 196 (class 1259 OID 16408)
-- Name: Customers_Id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public."Customers_Id_seq"
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public."Customers_Id_seq" OWNER TO postgres;

--
-- TOC entry 2803 (class 0 OID 0)
-- Dependencies: 196
-- Name: Customers_Id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public."Customers_Id_seq" OWNED BY public."Customers"."Id";


--
-- TOC entry 2671 (class 2604 OID 16413)
-- Name: Customers Id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Customers" ALTER COLUMN "Id" SET DEFAULT nextval('public."Customers_Id_seq"'::regclass);


--
-- TOC entry 2673 (class 2606 OID 16418)
-- Name: Customers Customers_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Customers"
    ADD CONSTRAINT "Customers_pkey" PRIMARY KEY ("Id");


-- Completed on 2018-03-12 03:52:30

--
-- PostgreSQL database dump complete
--


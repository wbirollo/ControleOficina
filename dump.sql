--
-- PostgreSQL database dump
--

-- Dumped from database version 15.1
-- Dumped by pg_dump version 15.1

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- Name: Cliente; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Cliente" (
    id uuid NOT NULL,
    data_criacao timestamp with time zone NOT NULL,
    "Nome" character varying(100) NOT NULL,
    "NumeroTelefone" character varying(20) NOT NULL,
    "Email" character varying(100) NOT NULL,
    "Cpf" character varying(20) NOT NULL,
    "Complemento" character varying(200),
    "Logradouro" character varying(100) NOT NULL,
    "Numero" character varying(10) NOT NULL,
    "Bairro" character varying(100) NOT NULL,
    "Cidade" character varying(100) NOT NULL,
    "Estado" character varying(50) NOT NULL,
    "Pais" character varying(50) NOT NULL
);


ALTER TABLE public."Cliente" OWNER TO postgres;

--
-- Name: Funcionario; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Funcionario" (
    id uuid NOT NULL,
    data_criacao timestamp with time zone NOT NULL,
    "Nome" character varying(100) NOT NULL,
    "NumeroTelefone" character varying(20) NOT NULL,
    "Email" character varying(100) NOT NULL,
    "Cpf" character varying(20) NOT NULL,
    "Complemento" character varying(200),
    "Logradouro" character varying(100) NOT NULL,
    "Numero" character varying(10) NOT NULL,
    "Bairro" character varying(100) NOT NULL,
    "Cidade" character varying(100) NOT NULL,
    "Estado" character varying(50) NOT NULL,
    "Pais" character varying(50) NOT NULL
);


ALTER TABLE public."Funcionario" OWNER TO postgres;

--
-- Name: Peca; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Peca" (
    id uuid NOT NULL,
    "Descricao" character varying(500) NOT NULL,
    "ValorUnitario" numeric NOT NULL,
    data_criacao timestamp with time zone NOT NULL
);


ALTER TABLE public."Peca" OWNER TO postgres;

--
-- Name: PecaServico; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."PecaServico" (
    id uuid NOT NULL,
    "PecaId" uuid NOT NULL,
    "Quantidade" bigint NOT NULL,
    "ServicoId" uuid NOT NULL,
    data_criacao timestamp with time zone NOT NULL
);


ALTER TABLE public."PecaServico" OWNER TO postgres;

--
-- Name: Servico; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Servico" (
    id uuid NOT NULL,
    "Descricao" character varying(500) NOT NULL,
    "ValorServico" numeric NOT NULL,
    "DataFinalizacao" timestamp with time zone,
    "Status" integer NOT NULL,
    "FuncionarioId" uuid NOT NULL,
    "VeiculoId" uuid NOT NULL,
    data_criacao timestamp with time zone NOT NULL
);


ALTER TABLE public."Servico" OWNER TO postgres;

--
-- Name: Veiculo; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."Veiculo" (
    id uuid NOT NULL,
    "Marca" character varying(50) NOT NULL,
    "Modelo" character varying(50) NOT NULL,
    "Ano" character varying(10) NOT NULL,
    "Placa" character varying(10) NOT NULL,
    "ClienteId" uuid NOT NULL,
    data_criacao timestamp with time zone NOT NULL
);


ALTER TABLE public."Veiculo" OWNER TO postgres;

--
-- Name: __EFMigrationsHistory; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public."__EFMigrationsHistory" (
    "MigrationId" character varying(150) NOT NULL,
    "ProductVersion" character varying(32) NOT NULL
);


ALTER TABLE public."__EFMigrationsHistory" OWNER TO postgres;

--
-- Data for Name: Cliente; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public."Cliente" (id, data_criacao, "Nome", "NumeroTelefone", "Email", "Cpf", "Complemento", "Logradouro", "Numero", "Bairro", "Cidade", "Estado", "Pais") FROM stdin;
\.


--
-- Data for Name: Funcionario; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public."Funcionario" (id, data_criacao, "Nome", "NumeroTelefone", "Email", "Cpf", "Complemento", "Logradouro", "Numero", "Bairro", "Cidade", "Estado", "Pais") FROM stdin;
\.


--
-- Data for Name: Peca; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public."Peca" (id, "Descricao", "ValorUnitario", data_criacao) FROM stdin;
\.


--
-- Data for Name: PecaServico; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public."PecaServico" (id, "PecaId", "Quantidade", "ServicoId", data_criacao) FROM stdin;
\.


--
-- Data for Name: Servico; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public."Servico" (id, "Descricao", "ValorServico", "DataFinalizacao", "Status", "FuncionarioId", "VeiculoId", data_criacao) FROM stdin;
\.


--
-- Data for Name: Veiculo; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public."Veiculo" (id, "Marca", "Modelo", "Ano", "Placa", "ClienteId", data_criacao) FROM stdin;
\.


--
-- Data for Name: __EFMigrationsHistory; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public."__EFMigrationsHistory" ("MigrationId", "ProductVersion") FROM stdin;
20230419105721_Initial	6.0.16
\.


--
-- Name: Cliente PK_Cliente; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Cliente"
    ADD CONSTRAINT "PK_Cliente" PRIMARY KEY (id);


--
-- Name: Funcionario PK_Funcionario; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Funcionario"
    ADD CONSTRAINT "PK_Funcionario" PRIMARY KEY (id);


--
-- Name: Peca PK_Peca; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Peca"
    ADD CONSTRAINT "PK_Peca" PRIMARY KEY (id);


--
-- Name: PecaServico PK_PecaServico; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."PecaServico"
    ADD CONSTRAINT "PK_PecaServico" PRIMARY KEY (id);


--
-- Name: Servico PK_Servico; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Servico"
    ADD CONSTRAINT "PK_Servico" PRIMARY KEY (id);


--
-- Name: Veiculo PK_Veiculo; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Veiculo"
    ADD CONSTRAINT "PK_Veiculo" PRIMARY KEY (id);


--
-- Name: __EFMigrationsHistory PK___EFMigrationsHistory; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."__EFMigrationsHistory"
    ADD CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY ("MigrationId");


--
-- Name: IX_PecaServico_PecaId; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX "IX_PecaServico_PecaId" ON public."PecaServico" USING btree ("PecaId");


--
-- Name: IX_PecaServico_ServicoId; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX "IX_PecaServico_ServicoId" ON public."PecaServico" USING btree ("ServicoId");


--
-- Name: IX_Servico_FuncionarioId; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX "IX_Servico_FuncionarioId" ON public."Servico" USING btree ("FuncionarioId");


--
-- Name: IX_Servico_VeiculoId; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX "IX_Servico_VeiculoId" ON public."Servico" USING btree ("VeiculoId");


--
-- Name: IX_Veiculo_ClienteId; Type: INDEX; Schema: public; Owner: postgres
--

CREATE INDEX "IX_Veiculo_ClienteId" ON public."Veiculo" USING btree ("ClienteId");


--
-- Name: PecaServico FK_PecaServico_Peca_PecaId; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."PecaServico"
    ADD CONSTRAINT "FK_PecaServico_Peca_PecaId" FOREIGN KEY ("PecaId") REFERENCES public."Peca"(id) ON DELETE CASCADE;


--
-- Name: PecaServico FK_PecaServico_Servico_ServicoId; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."PecaServico"
    ADD CONSTRAINT "FK_PecaServico_Servico_ServicoId" FOREIGN KEY ("ServicoId") REFERENCES public."Servico"(id) ON DELETE CASCADE;


--
-- Name: Servico FK_Servico_Funcionario_FuncionarioId; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Servico"
    ADD CONSTRAINT "FK_Servico_Funcionario_FuncionarioId" FOREIGN KEY ("FuncionarioId") REFERENCES public."Funcionario"(id) ON DELETE CASCADE;


--
-- Name: Servico FK_Servico_Veiculo_VeiculoId; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Servico"
    ADD CONSTRAINT "FK_Servico_Veiculo_VeiculoId" FOREIGN KEY ("VeiculoId") REFERENCES public."Veiculo"(id) ON DELETE CASCADE;


--
-- Name: Veiculo FK_Veiculo_Cliente_ClienteId; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public."Veiculo"
    ADD CONSTRAINT "FK_Veiculo_Cliente_ClienteId" FOREIGN KEY ("ClienteId") REFERENCES public."Cliente"(id) ON DELETE CASCADE;


--
-- PostgreSQL database dump complete
--


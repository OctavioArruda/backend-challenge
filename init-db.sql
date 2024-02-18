-- Drop tables if they exist to start fresh
DROP TABLE IF EXISTS transacoes;
DROP TABLE IF EXISTS clientes;

-- Create clientes table with an auto-incrementing PK and an index on the PK
CREATE TABLE clientes (
    id BIGSERIAL PRIMARY KEY,
    nome VARCHAR(255),
    limite BIGINT,
    saldo BIGINT
);

-- PostgreSQL automatically creates an index for the primary key

-- Create transacoes table with an auto-incrementing PK, a FK to clientes, and indexes
CREATE TABLE transacoes (
    id BIGSERIAL PRIMARY KEY,
    cliente_id BIGINT,
    valor BIGINT,
    tipo VARCHAR(1),
    descricao VARCHAR(155),
    realizada_em TIMESTAMP,
    CONSTRAINT fk_cliente FOREIGN KEY(cliente_id) REFERENCES clientes(id)
);

-- PostgreSQL automatically creates an index for the primary key
-- Create an index for the foreign key for better join performance
CREATE INDEX idx_transacoes_cliente_id ON transacoes(cliente_id);

-- Insert sample data into clientes
INSERT INTO clientes (nome, limite, saldo) VALUES
('Rhys', 100000, 0),
('Ayn', 80000, 0),
('Lyle', 1000000, 0),
('Sari', 10000000, 0),
('Sean', 500000, 0);

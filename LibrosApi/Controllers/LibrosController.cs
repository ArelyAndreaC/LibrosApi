using Microsoft.AspNetCore.Mvc;
using LibrosApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LibrosApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibrosController : ControllerBase
    {
        static List<Libros> inventario = new List<Libros>()
{
    // ── PREESCOLAR ─────────────────────────────────────────────────────────
    // PRIMER GRADO
    new Libros() {Id=1,  Codigo="0000000001", Nombre="Múltiples Lenguajes.",                                                         Categoria="Preescolar", Subcategoria="PRIMER GRADO",   Descripcion="162 páginas", Enlace="https://libros.conaliteg.gob.mx/2025/K1MLA.htm"},
    new Libros() {Id=2,  Codigo="0000000002", Nombre="Explorar e imaginar con mi libro de Preescolar.",                              Categoria="Preescolar", Subcategoria="PRIMER GRADO",   Descripcion="66 páginas",  Enlace="https://libros.conaliteg.gob.mx/2025/K1LPA.htm"},
    new Libros() {Id=3,  Codigo="0000000003", Nombre="Jugar e imaginar con mi material manipulable de Preescolar.",                 Categoria="Preescolar", Subcategoria="PRIMER GRADO",   Descripcion="64 páginas",  Enlace="https://libros.conaliteg.gob.mx/2025/K1LMA.htm"},
    // SEGUNDO GRADO
    new Libros() {Id=4,  Codigo="0000000004", Nombre="Crianza para la libertad.",                                                    Categoria="Preescolar", Subcategoria="SEGUNDO GRADO",  Descripcion="178 páginas", Enlace="https://libros.conaliteg.gob.mx/2025/K0CFA.htm"},
    new Libros() {Id=5,  Codigo="0000000005", Nombre="Posibilidades de trabajo para la acción transformadora y el codiseño.",       Categoria="Preescolar", Subcategoria="SEGUNDO GRADO",  Descripcion="202 páginas", Enlace="https://libros.conaliteg.gob.mx/2025/K0TAM.htm"},
    new Libros() {Id=6,  Codigo="0000000006", Nombre="Jugar e imaginar con mi material manipulable de Preescolar.",                 Categoria="Preescolar", Subcategoria="SEGUNDO GRADO",  Descripcion="72 páginas",  Enlace="https://libros.conaliteg.gob.mx/2025/K2LMA.htm"},
    // TERCER GRADO
    new Libros() {Id=7,  Codigo="0000000007", Nombre="Láminas de diálogo con manifestaciones culturales y artísticas.",            Categoria="Preescolar", Subcategoria="TERCER GRADO",   Descripcion="22 páginas",  Enlace="https://libros.conaliteg.gob.mx/2025/K3LDG.htm"},
    new Libros() {Id=8,  Codigo="0000000008", Nombre="Explorar e imaginar con mi libro de Preescolar.",                             Categoria="Preescolar", Subcategoria="TERCER GRADO",   Descripcion="58 páginas",  Enlace="https://libros.conaliteg.gob.mx/2025/K3LPA.htm"},
    new Libros() {Id=9,  Codigo="0000000009", Nombre="Un libro sin recetas para la maestra.",                                       Categoria="Preescolar", Subcategoria="TERCER GRADO",   Descripcion="138 páginas", Enlace="https://libros.conaliteg.gob.mx/2025/K0LPM.htm"},

    // ── PRIMARIA ───────────────────────────────────────────────────────────
    // PRIMER GRADO
    new Libros() {Id=10, Codigo="0000000010", Nombre="Un libro sin recetas, para la maestra y el maestro.",                         Categoria="Primaria",   Subcategoria="PRIMER GRADO",   Descripcion="90 páginas",  Enlace="https://libros.conaliteg.gob.mx/2025/P1LPM.htm"},
    new Libros() {Id=11, Codigo="0000000011", Nombre="Múltiples lenguajes.",                                                         Categoria="Primaria",   Subcategoria="PRIMER GRADO",   Descripcion="258 páginas", Enlace="https://libros.conaliteg.gob.mx/2025/P1MLA.htm"},
    new Libros() {Id=12, Codigo="0000000012", Nombre="Proyectos de Aula.",                                                           Categoria="Primaria",   Subcategoria="PRIMER GRADO",   Descripcion="242 páginas", Enlace="https://libros.conaliteg.gob.mx/2025/P1PAA.htm"},
    new Libros() {Id=13, Codigo="0000000013", Nombre="Proyectos Comunitarios.",                                                      Categoria="Primaria",   Subcategoria="PRIMER GRADO",   Descripcion="274 páginas", Enlace="https://libros.conaliteg.gob.mx/2025/P1PCA.htm"},
    new Libros() {Id=14, Codigo="0000000014", Nombre="Proyectos Escolares.",                                                         Categoria="Primaria",   Subcategoria="PRIMER GRADO",   Descripcion="274 páginas", Enlace="https://libros.conaliteg.gob.mx/2025/P1PEA.htm"},
    new Libros() {Id=15, Codigo="0000000015", Nombre="Nuestros saberes: Libro para alumnos, maestros y familia.",                   Categoria="Primaria",   Subcategoria="PRIMER GRADO",   Descripcion="250 páginas", Enlace="https://libros.conaliteg.gob.mx/2025/P1SDA.htm"},
    new Libros() {Id=16, Codigo="0000000016", Nombre="Múltiples lenguajes, Trazos y números.",                                      Categoria="Primaria",   Subcategoria="PRIMER GRADO",   Descripcion="130 páginas", Enlace="https://libros.conaliteg.gob.mx/2025/P1TNA.htm"},
    new Libros() {Id=17, Codigo="0000000017", Nombre="Múltiples lenguajes. Trazos y palabras.",                                     Categoria="Primaria",   Subcategoria="PRIMER GRADO",   Descripcion="130 páginas", Enlace="https://libros.conaliteg.gob.mx/2025/P1TPA.htm"},
    // SEGUNDO GRADO
    new Libros() {Id=18, Codigo="0000000018", Nombre="Múltiples lenguajes.",                                                         Categoria="Primaria",   Subcategoria="SEGUNDO GRADO",  Descripcion="258 páginas", Enlace="https://libros.conaliteg.gob.mx/2025/P2MLA.htm"},
    new Libros() {Id=19, Codigo="0000000019", Nombre="Proyectos de Aula.",                                                           Categoria="Primaria",   Subcategoria="SEGUNDO GRADO",  Descripcion="242 páginas", Enlace="https://libros.conaliteg.gob.mx/2025/P2PAA.htm"},
    new Libros() {Id=20, Codigo="0000000020", Nombre="Proyectos Comunitarios.",                                                      Categoria="Primaria",   Subcategoria="SEGUNDO GRADO",  Descripcion="274 páginas", Enlace="https://libros.conaliteg.gob.mx/2025/P2PCA.htm"},
    new Libros() {Id=21, Codigo="0000000021", Nombre="Proyectos Escolares.",                                                         Categoria="Primaria",   Subcategoria="SEGUNDO GRADO",  Descripcion="274 páginas", Enlace="https://libros.conaliteg.gob.mx/2025/P2PEA.htm"},
    new Libros() {Id=22, Codigo="0000000022", Nombre="Nuestros saberes: Libro para alumnos, maestros y familia.",                   Categoria="Primaria",   Subcategoria="SEGUNDO GRADO",  Descripcion="250 páginas", Enlace="https://libros.conaliteg.gob.mx/2025/P2SDA.htm"},
    new Libros() {Id=23, Codigo="0000000023", Nombre="Múltiples lenguajes, Trazos y números.",                                      Categoria="Primaria",   Subcategoria="SEGUNDO GRADO",  Descripcion="130 páginas", Enlace="https://libros.conaliteg.gob.mx/2025/P2TNA.htm"},
    new Libros() {Id=24, Codigo="0000000024", Nombre="Múltiples lenguajes. Trazos y palabras.",                                     Categoria="Primaria",   Subcategoria="SEGUNDO GRADO",  Descripcion="130 páginas", Enlace="https://libros.conaliteg.gob.mx/2025/P2TPA.htm"},
    // TERCER GRADO
    new Libros() {Id=25, Codigo="0000000025", Nombre="Proyectos de Aula.",                                                           Categoria="Primaria",   Subcategoria="TERCER GRADO",   Descripcion="242 páginas", Enlace="https://libros.conaliteg.gob.mx/2025/P3PAA.htm"},
    new Libros() {Id=26, Codigo="0000000026", Nombre="Proyectos Comunitarios.",                                                      Categoria="Primaria",   Subcategoria="TERCER GRADO",   Descripcion="274 páginas", Enlace="https://libros.conaliteg.gob.mx/2025/P3PCA.htm"},
    new Libros() {Id=27, Codigo="0000000027", Nombre="Proyectos Escolares.",                                                         Categoria="Primaria",   Subcategoria="TERCER GRADO",   Descripcion="274 páginas", Enlace="https://libros.conaliteg.gob.mx/2025/P3PEA.htm"},
    new Libros() {Id=28, Codigo="0000000028", Nombre="Nuestros saberes: Libro para alumnos, maestros y familia.",                   Categoria="Primaria",   Subcategoria="TERCER GRADO",   Descripcion="250 páginas", Enlace="https://libros.conaliteg.gob.mx/2025/P3SDA.htm"},
    new Libros() {Id=29, Codigo="0000000029", Nombre="Libro de texto",                                                              Categoria="Primaria",   Subcategoria="TERCER GRADO",   Descripcion="320 páginas", Enlace="https://libros.conaliteg.gob.mx/2025/P3LPA.htm"},
    // CUARTO GRADO
    new Libros() {Id=30, Codigo="0000000030", Nombre="Proyectos de Aula.",                                                           Categoria="Primaria",   Subcategoria="CUARTO GRADO",   Descripcion="242 páginas", Enlace="https://libros.conaliteg.gob.mx/2025/P4PAA.htm"},
    new Libros() {Id=31, Codigo="0000000031", Nombre="Proyectos Comunitarios.",                                                      Categoria="Primaria",   Subcategoria="CUARTO GRADO",   Descripcion="274 páginas", Enlace="https://libros.conaliteg.gob.mx/2025/P4PCA.htm"},
    new Libros() {Id=32, Codigo="0000000032", Nombre="Proyectos Escolares.",                                                         Categoria="Primaria",   Subcategoria="CUARTO GRADO",   Descripcion="274 páginas", Enlace="https://libros.conaliteg.gob.mx/2025/P4PEA.htm"},
    new Libros() {Id=33, Codigo="0000000033", Nombre="Nuestros saberes: Libro para alumnos, maestros y familia.",                   Categoria="Primaria",   Subcategoria="CUARTO GRADO",   Descripcion="250 páginas", Enlace="https://libros.conaliteg.gob.mx/2025/P4SDA.htm"},
    // QUINTO GRADO
    new Libros() {Id=34, Codigo="0000000034", Nombre="Proyectos de Aula.",                                                           Categoria="Primaria",   Subcategoria="QUINTO GRADO",   Descripcion="242 páginas", Enlace="https://libros.conaliteg.gob.mx/2025/P5PAA.htm"},
    new Libros() {Id=35, Codigo="0000000035", Nombre="Proyectos Comunitarios.",                                                      Categoria="Primaria",   Subcategoria="QUINTO GRADO",   Descripcion="274 páginas", Enlace="https://libros.conaliteg.gob.mx/2025/P5PCA.htm"},
    new Libros() {Id=36, Codigo="0000000036", Nombre="Proyectos Escolares.",                                                         Categoria="Primaria",   Subcategoria="QUINTO GRADO",   Descripcion="274 páginas", Enlace="https://libros.conaliteg.gob.mx/2025/P5PEA.htm"},
    new Libros() {Id=37, Codigo="0000000037", Nombre="Nuestros saberes: Libro para alumnos, maestros y familia.",                   Categoria="Primaria",   Subcategoria="QUINTO GRADO",   Descripcion="250 páginas", Enlace="https://libros.conaliteg.gob.mx/2025/P5SDA.htm"},
    // SEXTO GRADO
    new Libros() {Id=38, Codigo="0000000038", Nombre="Proyectos de Aula.",                                                           Categoria="Primaria",   Subcategoria="SEXTO GRADO",    Descripcion="242 páginas", Enlace="https://libros.conaliteg.gob.mx/2025/P6PAA.htm"},
    new Libros() {Id=39, Codigo="0000000039", Nombre="Proyectos Comunitarios.",                                                      Categoria="Primaria",   Subcategoria="SEXTO GRADO",    Descripcion="274 páginas", Enlace="https://libros.conaliteg.gob.mx/2025/P6PCA.htm"},
    new Libros() {Id=40, Codigo="0000000040", Nombre="Proyectos Escolares.",                                                         Categoria="Primaria",   Subcategoria="SEXTO GRADO",    Descripcion="274 páginas", Enlace="https://libros.conaliteg.gob.mx/2025/P6PEA.htm"},
    new Libros() {Id=41, Codigo="0000000041", Nombre="Nuestros saberes: Libro para alumnos, maestros y familia.",                   Categoria="Primaria",   Subcategoria="SEXTO GRADO",    Descripcion="250 páginas", Enlace="https://libros.conaliteg.gob.mx/2025/P6SDA.htm"},

    // ── SECUNDARIA ─────────────────────────────────────────────────────────
    // PRIMER GRADO
    new Libros() {Id=42, Codigo="0000000042", Nombre="Proyectos de Aula.",                                                           Categoria="Secundaria", Subcategoria="PRIMER GRADO",   Descripcion="242 páginas", Enlace="https://libros.conaliteg.gob.mx/2025/S1PAA.htm"},
    new Libros() {Id=43, Codigo="0000000043", Nombre="Proyectos Comunitarios.",                                                      Categoria="Secundaria", Subcategoria="PRIMER GRADO",   Descripcion="274 páginas", Enlace="https://libros.conaliteg.gob.mx/2025/S1PCA.htm"},
    new Libros() {Id=44, Codigo="0000000044", Nombre="Proyectos Escolares.",                                                         Categoria="Secundaria", Subcategoria="PRIMER GRADO",   Descripcion="274 páginas", Enlace="https://libros.conaliteg.gob.mx/2025/S1PEA.htm"},
    new Libros() {Id=45, Codigo="0000000045", Nombre="Nuestros saberes: Libro para alumnos, maestros y familia.",                   Categoria="Secundaria", Subcategoria="PRIMER GRADO",   Descripcion="250 páginas", Enlace="https://libros.conaliteg.gob.mx/2025/S1SDA.htm"},
    // SEGUNDO GRADO
    new Libros() {Id=46, Codigo="0000000046", Nombre="Proyectos de Aula.",                                                           Categoria="Secundaria", Subcategoria="SEGUNDO GRADO",  Descripcion="242 páginas", Enlace="https://libros.conaliteg.gob.mx/2025/S2PAA.htm"},
    new Libros() {Id=47, Codigo="0000000047", Nombre="Proyectos Comunitarios.",                                                      Categoria="Secundaria", Subcategoria="SEGUNDO GRADO",  Descripcion="274 páginas", Enlace="https://libros.conaliteg.gob.mx/2025/S2PCA.htm"},
    new Libros() {Id=48, Codigo="0000000048", Nombre="Proyectos Escolares.",                                                         Categoria="Secundaria", Subcategoria="SEGUNDO GRADO",  Descripcion="274 páginas", Enlace="https://libros.conaliteg.gob.mx/2025/S2PEA.htm"},
    new Libros() {Id=49, Codigo="0000000049", Nombre="Nuestros saberes: Libro para alumnos, maestros y familia.",                   Categoria="Secundaria", Subcategoria="SEGUNDO GRADO",  Descripcion="250 páginas", Enlace="https://libros.conaliteg.gob.mx/2025/S2SDA.htm"},
    // TERCER GRADO
    new Libros() {Id=50, Codigo="0000000050", Nombre="Proyectos de Aula.",                                                           Categoria="Secundaria", Subcategoria="TERCER GRADO",   Descripcion="242 páginas", Enlace="https://libros.conaliteg.gob.mx/2025/S3PAA.htm"},
    new Libros() {Id=51, Codigo="0000000051", Nombre="Proyectos Comunitarios.",                                                      Categoria="Secundaria", Subcategoria="TERCER GRADO",   Descripcion="274 páginas", Enlace="https://libros.conaliteg.gob.mx/2025/S3PCA.htm"},
    new Libros() {Id=52, Codigo="0000000052", Nombre="Proyectos Escolares.",                                                         Categoria="Secundaria", Subcategoria="TERCER GRADO",   Descripcion="274 páginas", Enlace="https://libros.conaliteg.gob.mx/2025/S3PEA.htm"},
    new Libros() {Id=53, Codigo="0000000053", Nombre="Nuestros saberes: Libro para alumnos, maestros y familia.",                   Categoria="Secundaria", Subcategoria="TERCER GRADO",   Descripcion="250 páginas", Enlace="https://libros.conaliteg.gob.mx/2025/S3SDA.htm"},

    // ── BACHILLERATO ───────────────────────────────────────────────────────
    // SEMESTRE 1
    new Libros() {Id=54, Codigo="0000000054", Nombre="Lectura, Expresión Oral y Escrita I",          Categoria="Bachillerato", Subcategoria="SEMESTRE 1", Descripcion="200 páginas", Enlace="https://dgb.sep.gob.mx/storage/recursos/2024/09/leoe1.pdf"},
    new Libros() {Id=55, Codigo="0000000055", Nombre="Matemáticas I",                                Categoria="Bachillerato", Subcategoria="SEMESTRE 1", Descripcion="220 páginas", Enlace="https://dgb.sep.gob.mx/storage/recursos/2024/09/mat1.pdf"},
    new Libros() {Id=56, Codigo="0000000056", Nombre="Introducción a las Ciencias Sociales",          Categoria="Bachillerato", Subcategoria="SEMESTRE 1", Descripcion="195 páginas", Enlace="https://dgb.sep.gob.mx/storage/recursos/2024/09/ics.pdf"},
    new Libros() {Id=57, Codigo="0000000057", Nombre="Química I",                                    Categoria="Bachillerato", Subcategoria="SEMESTRE 1", Descripcion="210 páginas", Enlace="https://dgb.sep.gob.mx/storage/recursos/2024/09/qui1.pdf"},
    new Libros() {Id=58, Codigo="0000000058", Nombre="Informática I",                                Categoria="Bachillerato", Subcategoria="SEMESTRE 1", Descripcion="180 páginas", Enlace="https://dgb.sep.gob.mx/storage/recursos/2024/09/inf1.pdf"},
    // SEMESTRE 2
    new Libros() {Id=59, Codigo="0000000059", Nombre="Lectura, Expresión Oral y Escrita II",         Categoria="Bachillerato", Subcategoria="SEMESTRE 2", Descripcion="200 páginas", Enlace="https://dgb.sep.gob.mx/storage/recursos/2024/09/leoe2.pdf"},
    new Libros() {Id=60, Codigo="0000000060", Nombre="Matemáticas II",                               Categoria="Bachillerato", Subcategoria="SEMESTRE 2", Descripcion="225 páginas", Enlace="https://dgb.sep.gob.mx/storage/recursos/2024/09/mat2.pdf"},
    new Libros() {Id=61, Codigo="0000000061", Nombre="Historia de México I",                         Categoria="Bachillerato", Subcategoria="SEMESTRE 2", Descripcion="240 páginas", Enlace="https://dgb.sep.gob.mx/storage/recursos/2024/09/hm1.pdf"},
    new Libros() {Id=62, Codigo="0000000062", Nombre="Física I",                                     Categoria="Bachillerato", Subcategoria="SEMESTRE 2", Descripcion="215 páginas", Enlace="https://dgb.sep.gob.mx/storage/recursos/2024/09/fis1.pdf"},
    new Libros() {Id=63, Codigo="0000000063", Nombre="Informática II",                               Categoria="Bachillerato", Subcategoria="SEMESTRE 2", Descripcion="185 páginas", Enlace="https://dgb.sep.gob.mx/storage/recursos/2024/09/inf2.pdf"},
    // SEMESTRE 3
    new Libros() {Id=64, Codigo="0000000064", Nombre="Literatura I",                                 Categoria="Bachillerato", Subcategoria="SEMESTRE 3", Descripcion="212 páginas", Enlace="https://dgb.sep.gob.mx/storage/recursos/2024/09/lit1.pdf"},
    new Libros() {Id=65, Codigo="0000000065", Nombre="Matemáticas III",                              Categoria="Bachillerato", Subcategoria="SEMESTRE 3", Descripcion="230 páginas", Enlace="https://dgb.sep.gob.mx/storage/recursos/2024/09/mat3.pdf"},
    new Libros() {Id=66, Codigo="0000000066", Nombre="Ecología y Medio Ambiente",                    Categoria="Bachillerato", Subcategoria="SEMESTRE 3", Descripcion="198 páginas", Enlace="https://dgb.sep.gob.mx/storage/recursos/2024/09/ema.pdf"},
    new Libros() {Id=67, Codigo="0000000067", Nombre="Biología I",                                   Categoria="Bachillerato", Subcategoria="SEMESTRE 3", Descripcion="220 páginas", Enlace="https://dgb.sep.gob.mx/storage/recursos/2024/09/bio1.pdf"},
    new Libros() {Id=68, Codigo="0000000068", Nombre="Física II",                                    Categoria="Bachillerato", Subcategoria="SEMESTRE 3", Descripcion="218 páginas", Enlace="https://dgb.sep.gob.mx/storage/recursos/2024/09/fis2.pdf"},
    new Libros() {Id=69, Codigo="0000000069", Nombre="Filosofía I",                                  Categoria="Bachillerato", Subcategoria="SEMESTRE 3", Descripcion="190 páginas", Enlace="https://dgb.sep.gob.mx/storage/recursos/2024/09/fil1.pdf"},
    // SEMESTRE 4
    new Libros() {Id=70, Codigo="0000000095", Nombre="Ética I",                                      Categoria="Bachillerato", Subcategoria="SEMESTRE 4", Descripcion="171 páginas", Enlace="https://dgb.sep.gob.mx/storage/recursos/2024/09/JbZnDG0A4y-Etica-I.pdf"},
    new Libros() {Id=71, Codigo="0000000096", Nombre="Física III",                                   Categoria="Bachillerato", Subcategoria="SEMESTRE 4", Descripcion="258 páginas", Enlace="https://dgb.sep.gob.mx/storage/recursos/2024/09/l9fVSgbZAN-Fisica-III.pdf"},
    new Libros() {Id=72, Codigo="0000000097", Nombre="Lengua Adicional al Español III",              Categoria="Bachillerato", Subcategoria="SEMESTRE 4", Descripcion="176 páginas", Enlace="https://dgb.sep.gob.mx/storage/recursos/2024/09/wTOJe6yCZo-Lengua-Adicional-al-Espanol-III.pdf"},
    new Libros() {Id=73, Codigo="0000000098", Nombre="Biología II",                                  Categoria="Bachillerato", Subcategoria="SEMESTRE 4", Descripcion="218 páginas", Enlace="https://dgb.sep.gob.mx/storage/recursos/2024/09/MxWcTXG8OF-Biologia-II.pdf"},
    new Libros() {Id=74, Codigo="0000000099", Nombre="Historia de México II",                        Categoria="Bachillerato", Subcategoria="SEMESTRE 4", Descripcion="250 páginas", Enlace="https://dgb.sep.gob.mx/storage/recursos/2024/09/n3fi6Mj2wA-Historia-de-Mexico-II.pdf"},
    new Libros() {Id=75, Codigo="0000000100", Nombre="Lengua Adicional al Español IV",               Categoria="Bachillerato", Subcategoria="SEMESTRE 4", Descripcion="186 páginas", Enlace="https://dgb.sep.gob.mx/storage/recursos/2024/09/5Wmrh8YXgh-Lengua-Adicional-al-Espanol-IV.pdf"},
    new Libros() {Id=76, Codigo="0000000101", Nombre="Literatura II",                                Categoria="Bachillerato", Subcategoria="SEMESTRE 4", Descripcion="212 páginas", Enlace="https://dgb.sep.gob.mx/storage/recursos/2024/09/XGzUATEJHY-Literatura-II.pdf"},
    new Libros() {Id=77, Codigo="0000000102", Nombre="Química II",                                   Categoria="Bachillerato", Subcategoria="SEMESTRE 4", Descripcion="324 páginas", Enlace="https://dgb.sep.gob.mx/storage/recursos/2024/09/TdnYTplrI2-Quimica-II.pdf"},
    // SEMESTRE 5
    new Libros() {Id=78, Codigo="0000000103", Nombre="Estructura socioeconómica de México",          Categoria="Bachillerato", Subcategoria="SEMESTRE 5", Descripcion="200 páginas", Enlace="https://dgb.sep.gob.mx/storage/recursos/2024/09/sTams4PFyy-Estructura%20socioecon%C3%B3mica%20de%20M%C3%A9xico.pdf"},
    new Libros() {Id=79, Codigo="0000000104", Nombre="Historia Universal Contemporánea",             Categoria="Bachillerato", Subcategoria="SEMESTRE 5", Descripcion="263 páginas", Enlace="https://dgb.sep.gob.mx/storage/recursos/2024/09/xviD7hv8rg-Historia-Universal-Contemporanea.pdf"},
    new Libros() {Id=80, Codigo="0000000105", Nombre="Geografía",                                    Categoria="Bachillerato", Subcategoria="SEMESTRE 5", Descripcion="355 páginas", Enlace="https://dgb.sep.gob.mx/storage/recursos/2024/09/majncdvECU-Geografia.pdf"},
    new Libros() {Id=81, Codigo="0000000106", Nombre="Ciencias de la Comunicación I",                Categoria="Bachillerato", Subcategoria="SEMESTRE 5", Descripcion="130 páginas", Enlace="https://dgb.sep.gob.mx/storage/recursos/2024/09/7E5ZRtOLre-Ciencias-de-la-Comunicacion-I.pdf"},
    new Libros() {Id=82, Codigo="0000000107", Nombre="Derecho I",                                    Categoria="Bachillerato", Subcategoria="SEMESTRE 5", Descripcion="171 páginas", Enlace="https://dgb.sep.gob.mx/storage/recursos/2024/09/VhRiPJp2GF-Derecho-I.pdf"},
    new Libros() {Id=83, Codigo="0000000108", Nombre="Probabilidad y Estadística I",                 Categoria="Bachillerato", Subcategoria="SEMESTRE 5", Descripcion="156 páginas", Enlace="https://dgb.sep.gob.mx/storage/recursos/2024/09/Ck6sJhToh4-Probabilidad-y-Estadistica-I.pdf"},
    new Libros() {Id=84, Codigo="0000000109", Nombre="Desarrollo Comunitario",                       Categoria="Bachillerato", Subcategoria="SEMESTRE 5", Descripcion="231 páginas", Enlace="https://dgb.sep.gob.mx/storage/recursos/2024/09/r1Y5FD0aq5-Desarrollo-Comunitario.pdf"},
    // SEMESTRE 6
    new Libros() {Id=85, Codigo="0000000110", Nombre="Metodología de la Investigación",              Categoria="Bachillerato", Subcategoria="SEMESTRE 6", Descripcion="240 páginas", Enlace="https://dgb.sep.gob.mx/storage/recursos/2024/09/rXVlXTGhBF-Metodologia-de-la-investigacion.pdf"},
    new Libros() {Id=86, Codigo="0000000111", Nombre="Ciencias de la Salud II",                      Categoria="Bachillerato", Subcategoria="SEMESTRE 6", Descripcion="256 páginas", Enlace="https://dgb.sep.gob.mx/storage/recursos/2024/09/btY8Fq0GVL-Ciencias-de-la-Salud-II-O.pdf"},
    new Libros() {Id=87, Codigo="0000000112", Nombre="Ciencias de la Comunicación II",               Categoria="Bachillerato", Subcategoria="SEMESTRE 6", Descripcion="183 páginas", Enlace="https://dgb.sep.gob.mx/storage/recursos/2024/09/yhekTcmLGq-Ciencias-de-la-Comunicacion-II.pdf"},
    new Libros() {Id=88, Codigo="0000000113", Nombre="Derecho II",                                   Categoria="Bachillerato", Subcategoria="SEMESTRE 6", Descripcion="210 páginas", Enlace="https://dgb.sep.gob.mx/storage/recursos/2024/09/9d60hpVfpo-Derecho-II.pdf"},
    new Libros() {Id=89, Codigo="0000000114", Nombre="Filosofía",                                    Categoria="Bachillerato", Subcategoria="SEMESTRE 6", Descripcion="196 páginas", Enlace="https://dgb.sep.gob.mx/storage/recursos/2024/09/opvhdB4hIX-Filosofia.pdf"},
    new Libros() {Id=90, Codigo="0000000115", Nombre="Probabilidad y Estadística II",                Categoria="Bachillerato", Subcategoria="SEMESTRE 6", Descripcion="125 páginas", Enlace="https://dgb.sep.gob.mx/storage/recursos/2024/09/KMxRYZytC2-Probabilidad-y-estadistica-II.pdf"},
};
        // GET: api/<LibrosController>
        [HttpGet]
        public IEnumerable<Libros> Get()
        {
            return inventario;
        }

        // GET api/<LibrosController>/5
        [HttpGet("{id}")]
        public Libros? Get(int id)
        {
            foreach (Libros actual in inventario)
            {
                if (actual.Id == id)
                { return actual; }

            }
            return null;
        }

        // POST api/<LibrosController>
        [HttpPost]
        public void Post([FromBody] Libros nuevo)
        {
            int max = inventario.Count;
            nuevo.Id = max + 1;
            inventario.Add(nuevo);
        }

        // PUT api/<LibrosController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Libros actualizado)
        {
            for (int i = 0; i < inventario.Count; i++)
            {
                if (inventario[i].Id == id)
                {
                    // Actualizamos el objeto en esa posición
                    inventario[i] = actualizado;
                    return Ok(); // Salimos del método inmediatamente
                }
            }
            
            // Si terminó el ciclo y no encontró nada
            return NotFound();
        }

        // DELETE api/<LibrosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            for (int i = 0; i < inventario.Count; i++)
            {
                if (inventario[i].Id == id)
                {
                    inventario.RemoveAt(i);
                    break;
                }
            }
        }
    }
}

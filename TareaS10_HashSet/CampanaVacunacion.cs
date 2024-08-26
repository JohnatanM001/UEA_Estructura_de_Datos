using System;
using System.Collections.Generic;
using System.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

public class CampanaVacunacion
{
    private HashSet<Ciudadano> conjuntoTotal;
    private HashSet<Ciudadano> conjuntoPfizer;
    private HashSet<Ciudadano> conjuntoAstraZeneca;

    public CampanaVacunacion()
    {
        conjuntoTotal = new HashSet<Ciudadano>();
        conjuntoPfizer = new HashSet<Ciudadano>();
        conjuntoAstraZeneca = new HashSet<Ciudadano>();
    }

    public void InicializarConjuntos()
    {
        for (int i = 1; i <= 500; i++)
        {
            conjuntoTotal.Add(new Ciudadano(i));
        }
        
        for (int i = 1; i <= 75; i++)
        {
            conjuntoPfizer.Add(new Ciudadano(i));
            conjuntoAstraZeneca.Add(new Ciudadano(i + 75));
        }
    }

    public IEnumerable<Ciudadano> ObtenerCiudadanosNoVacunados()
    {
        return conjuntoTotal.Except(conjuntoPfizer.Union(conjuntoAstraZeneca));
    }

    public IEnumerable<Ciudadano> ObtenerCiudadanosConAmbasVacunas()
    {
        return conjuntoPfizer.Intersect(conjuntoAstraZeneca);
    }

    public IEnumerable<Ciudadano> ObtenerCiudadanosSoloPfizer()
    {
        return conjuntoPfizer.Except(conjuntoAstraZeneca);
    }

    public IEnumerable<Ciudadano> ObtenerCiudadanosSoloAstraZeneca()
    {
        return conjuntoAstraZeneca.Except(conjuntoPfizer);
    }

    public void GenerarReportePDF(string rutaArchivo)
    {
        Document documento = new Document();
        PdfWriter.GetInstance(documento, new FileStream(rutaArchivo, FileMode.Create));
        documento.Open();

        // Título
        documento.Add(new Paragraph("Reporte de Campaña de Vacunación COVID-19"));
        documento.Add(new Paragraph(" ")); // Espacio en blanco

        // Ciudadanos no vacunados
        documento.Add(new Paragraph("Ciudadanos no vacunados:"));
        documento.Add(new Paragraph(string.Join(", ", ObtenerCiudadanosNoVacunados().Select(c => c.Id))));
        documento.Add(new Paragraph(" ")); // Espacio en blanco

        // Ciudadanos con ambas vacunas
        documento.Add(new Paragraph("Ciudadanos con ambas vacunas:"));
        documento.Add(new Paragraph(string.Join(", ", ObtenerCiudadanosConAmbasVacunas().Select(c => c.Id))));
        documento.Add(new Paragraph(" ")); // Espacio en blanco

        // Ciudadanos solo con Pfizer
        documento.Add(new Paragraph("Ciudadanos solo con Pfizer:"));
        documento.Add(new Paragraph(string.Join(", ", ObtenerCiudadanosSoloPfizer().Select(c => c.Id))));
        documento.Add(new Paragraph(" ")); // Espacio en blanco

        // Ciudadanos solo con AstraZeneca
        documento.Add(new Paragraph("Ciudadanos solo con AstraZeneca:"));
        documento.Add(new Paragraph(string.Join(", ", ObtenerCiudadanosSoloAstraZeneca().Select(c => c.Id))));

        documento.Close();
    }
}

public class Ciudadano
{
    public int Id { get; set; }
    
    public Ciudadano(int id)
    {
        Id = id;
    }
}

<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0"
                xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:template match="/">
    <html>
      <head>
        <link rel="stylesheet" href="/Libraries/bootstrap/dist/css/bootstrap.min.css" />
      </head>
      <body>
        <h1 class="bg-danger text-center">Students</h1>
        <table class="table table-striped">
          <thead>
            <tr class="active">
              <th>
                Name
              </th>
              <th>
                Sex
              </th>
              <th>
                Birthdate
              </th>
              <th>
                Phone
              </th>
              <th>
                Email
              </th>
              <th>
                Course
              </th>
              <th>
                Specialty
              </th>
              <th>
                Faculty Number
              </th>
              <th>
                Taken exams
              </th>
            </tr>
          </thead>
          <tbody>
            <xsl:for-each select="students/student">
              <xsl:variable select="count(exams/exam)" name="count"/>
              <tr class="warning">
                <td class="text-center">
                  <xsl:value-of select="name"/>
                </td>
                <td class="text-center">
                  <xsl:value-of select="sex"/>
                </td>
                <td class="text-center">
                  <xsl:value-of select="birthDate"/>
                </td>
                <td class="text-center">
                  <xsl:value-of select="phone"/>
                </td>
                <td class="text-center">
                  <xsl:value-of select="email"/>
                </td>
                <td class="text-center">
                  <xsl:value-of select="course"/>
                </td>
                <td class="text-center">
                  <xsl:value-of select="specialty"/>
                </td>
                <td class="text-center">
                  <xsl:value-of select="facultyNumber"/>
                </td>
                <td class="text-center">
                  <xsl:for-each select="exams/exam">
                    <div class="list-group">
                      <div class="list-group-item list-group-item-success">
                        <b>Name: </b>
                        <xsl:value-of select="name"/>
                      </div>
                      <div class="list-group-item list-group-item-success">
                        <b>Tutor: </b>
                        <xsl:value-of select="tutor"/>
                      </div>
                      <div class="list-group-item list-group-item-success">
                        <b>Score: </b>
                        <xsl:value-of select="score"/>
                      </div>
                    </div>
                  </xsl:for-each>
                </td>

              </tr>
            </xsl:for-each>
          </tbody>
        </table>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>

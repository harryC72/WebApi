using IssueTracker.Dto;
using IssueTrackerShared.Data;
using IssueTrackerShared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http; 

namespace IssueTracker.Controllers
{
    public class IssuesController: ApiController
    {
        private IssuesRepository _issuesRepository;

        public IssuesController(IssuesRepository issuesRepository)
        {
            _issuesRepository = issuesRepository;
        }


        public IHttpActionResult Get()
        {
            return Ok( _issuesRepository.GetList());  
        }

        public IHttpActionResult Get(int id)
        {
            var issue = _issuesRepository.Get(id);

            if(issue == null)
            {
                return NotFound(); 
            }

            return Ok(issue);
        }

        public IHttpActionResult Post(IssueDto issue)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var issueModel = issue.ToModel();

            _issuesRepository.Add(issueModel);

                issue.Id = issueModel.Id;

            return Created(Url.Link("DefaultApi", new { controller = "Issues", id = issue.Id }), issue);
        }

        public IHttpActionResult Put(int id, IssueDto issue)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _issuesRepository.Update(issue.ToModel());

            return StatusCode(System.Net.HttpStatusCode.NoContent);
        }

        public void Delete(int id)
        {
            _issuesRepository.Delete(id);
        }
    }
}
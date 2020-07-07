using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Business.Abstract;
using WebAPI.Entities;

namespace WebAPI.API.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IUserService _userService;
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }
        /// <summary>
        /// Get All Users
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _userService.GetAll();
            return Ok(result);
        }
        /// <summary>
        /// Get User By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        [HttpGet]
        [Route("[action]/{id}")] // api/users/GetById/2
        public IActionResult GetById(int id)
        {
            var result = _userService.GetById(id);
            if (result != null)
            {
                return Ok(result); // status code  200 + data
            }
            return NotFound(result); // status code 404 + data
        }
        /// <summary>
        /// Get By User username
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        [Route("[action]/{userName}")]
        public IActionResult GetByUserName(string userName)
        {
            var result = _userService.GetByUserName(userName);
            if (result != null)
            {
                return Ok(result);
            }
            return NotFound(result);
        }
        /// <summary>
        /// Add the User
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Add([FromBody]Users users)
        {
            var result = _userService.Add(users);
            return CreatedAtAction("Get", new { id = result.Id }, users); // kaydedilen kullanıcıyı ekrana getiriyor
        }

        /// <summary>
        /// Update the User
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        [HttpPut]
        public IActionResult Update(Users users)
        {
            if (_userService.GetById(users.Id) != null)
            {
                return Ok(_userService.Update(users)); // status code  200 + data
            }
            return NotFound(users); // status code 404 + data
        }

        /// <summary>
        /// Delete the User
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("[action]/{id}")]
        public IActionResult Delete(int id)
        {
            if (_userService.GetById(id) != null)
            {
                _userService.Delete(id);
                return Ok(id); // status code  200 + data
            }
            return NotFound(id); // status code 404 + data
        }
    }
}